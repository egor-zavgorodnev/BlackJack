using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum CardPicture 
    { 
        A = 1,
        J,
        Q,
        K
    }
     
    public enum CardColor
    { 
        Spades = 0,
        Clubs,
        Diamods,
        Hearts   
    }

    public class Statistic
    { 
        //Статистика  
        private static int dealerWins = 0;
        private static int playerWins = 0;
        private static int draws = 0;

        /// <summary> 
        /// Сброс статистики 
        /// </summary>
        public static void resetStat() 
        {
            dealerWins = 0;
            playerWins = 0; 
            draws = 0;
        }
         
        public static int GetDealerWins()
        {
            return dealerWins;
        }  

        public static int GetPlayerWins()
        {
            return playerWins; 
        }
        public static int GetDraws()
        {
            return draws; 
        }

        public static void AddPlayerWin()
        {
            playerWins++;
        } 
        public static void AddDealerWin()
        { 
            dealerWins++; 
        }
        public static void AddDraw()
        {
            draws++;
        }
  
    } 
     
    public class Card 
    {
        // 1 ~ error!
        // 2
        // 3
        // ...
        // 10
        // 11 = A
        // 12 = J
        // 13 = Q
        // 14 = K
        // 15 ~ error!
        public int Number { get; set; }

        // 0, 1, 2, 3 
        public CardColor Color { get; set; }

        public static int GetPictureNumber(CardPicture color) 
        {
            return 10 + (int)color;
        }

        public static int GetMaxPictureNumber() 
        {
            return GetPictureNumber(CardPicture.K);
        }

        public static string[] NumberCaptions = new string[] { "", "A", "J", "Q", "K" }; 

        public static string[] ColorCaptions = new string[] { " \u2660", " \u2663", " \u2666", " \u2665" };  

        public int GetValue() 
        {    
            if(Number > 11)  
            {
                return 10;
            } 
            return Number;
        }

        public string GetCaption()
        {
            string res = string.Empty; 

            if(Number >= 11) 
            {
                res += NumberCaptions[Number-10]; 
            }
            else 
            {
                res += Number.ToString();
            }

            res += ColorCaptions[(int)Color]; 
            return res;
        } 
    }

    public class CardDeck
    {
        public List<Card> initialDeck = Create_52_deck();

        public static List<Card> Create_52_deck()  
        {
            var deck = new List<Card>();
            for (int i = 2; i <= Card.GetMaxPictureNumber(); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var card = new Card();
                    card.Number = i;
                    card.Color = (CardColor)j;
                    deck.Add(card);
                }
            }
            return deck;
        }

        public CardDeck() 
        {
            
        }

        public List<Card> cards = new List<Card>();

        static Random rnd = new Random(Environment.TickCount);

        public bool IsEmpty() 
        {
            return cards.Count == 0;
        }

        public bool HasCards()
        {
            return !IsEmpty();
        }

        public int CardCount() 
        {
            return cards.Count;
        } 
          
        public void Shuffle(int cardCount)
        {
            initialDeck = Create_52_deck(); 
            cards = new List<Card>();
             
            for (int i = 0; i < cardCount; i++) 
            {
                var index = rnd.Next(0, initialDeck.Count - 1);
                var card = initialDeck[index];
                cards.Add(card); 
                initialDeck.RemoveAt(index);
            } 
        }

        public Card PickCard() 
        {
            CheckNotEmpty();  

            var card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        private void CheckNotEmpty() 
        {
            if (IsEmpty())
            {
                throw new Exception("Eeeeee!");
            }
        }
    }
     
    public class FixedCardDeck
    {
        public static List<int> cards = new List<int>  //колода карт 
        {2,3,4,5,6,7,8,9,10,11}; 
         
        static Random rnd = new Random();


        public int value = cards[rnd.Next(0, cards.Count - 1)]; //"вытаскиваем" случайную карту 

    }

    public class Game
    { 

        public int totaldealer = 0; //сумма очков дилера
        private int totalplayer = 0; //сумма очков игрока  

        public string DealerCards; //карты дилера в строке 
  
        public List<Card> PlayerCardsList = new List<Card>(); //список карт игрока

        public string PlayerCards; //карты игрока в строке 


        public int CardCount { get; set; }

        public Game(int cardCount = 11) 
        {
            CardCount = cardCount;
        } 

        private CardDeck _deck = new CardDeck();

        /// <summary>
        /// Получить очки игрока 
        /// </summary>
        public int GetTotalPlayer()
        {
            return totalplayer;
        }
        /// <summary>
        /// Получить очки игрока 
        /// </summary> 
        public int GetTotalDealer()
        {
            return totaldealer;
        }
         
        /// <summary>
        /// Дилеру дается 1 карта
        /// </summary>
        public void DealerAddCard()
        { 
            Card newcard = _deck.PickCard();
            //тут ошибка  
            totaldealer += newcard.GetValue(); 
            DealerCards += newcard.GetCaption() + " "; 
        }
          
        /// <summary>
        /// Игроку дается одна карта 
        /// </summary> 
        public void PlayerAddCard() 
        {
            Card newcard = _deck.PickCard();
             
            totalplayer += newcard.GetValue();

            PlayerCardsList.Add(newcard); 
             
            PlayerCards += newcard.GetCaption() + " "; 
        }
          
        /// <summary>
        /// Есть ли туз среди карт игрока  
        /// </summary>
        /// <returns></returns> 
        public bool HasA() 
        {
            foreach (var CurrentCard in PlayerCardsList)
            {
                if (CurrentCard.Number == 11)
                {
                    return true;
                }
            }
            return false; 
        }
        /// <summary>
        /// Конец игры: определение победителя
        /// </summary>
        /// <returns></returns>
        public int EndCheck()
        {
            if ((totaldealer <= 21 & totaldealer > totalplayer) || totalplayer > 21)
            {
                Statistic.AddDealerWin(); 
                return 0; //победа дилера  
            }
            if ((totalplayer <= 21 & totalplayer > totaldealer) || totaldealer > 21)
            {
                Statistic.AddPlayerWin();
                return 1; //победа игрока 
            }
            else
            {
                Statistic.AddDraw(); 
            }
            return 2; //ничья 
        }

 
         
        /// <summary>      
        /// Конец игры: определение ситуации
        /// </summary>
        /// <returns></returns> 
        public string EndMessage()
        {
            if (totaldealer == totalplayer)
            {
                return "Ничья. Равное количество очков";
            }
            if (totaldealer > 21 & totalplayer > 21)
            {
                return "Ничья. Перебор карт у дилера и игрока";
            }
            if (totaldealer == 21)
            {
                return "Победа дилера. Блекджек!";
            }
            if (totaldealer > 21)
            {
                return "Победа игрока. Перебор у дилера";
            }
            if (totalplayer == 21)
            {
                return "Победа игрока. Блекджек!";
            }
            if (totalplayer > 21)
            {
                return "Победа дилера. Перебор у игрока";
            }
            if (totalplayer > totaldealer)
            {
                return "Победа игрока по очкам";
            }
            if (totaldealer > totalplayer)
            {
                return "Победа дилера по очкам";
            }

            EndGame();


            return "";
        }

        /// <summary>
        /// Обнуление очков 
        /// </summary>
        public void EndGame() 
        { 
            totaldealer = 0;   
            totalplayer = 0;
            PlayerCardsList.Clear();
            PlayerCards = ""; 
            DealerCards = ""; 

        } 
         
        /// <summary>
        /// Проверка на сплит 
        /// </summary>
        /// <returns></returns>
        public bool SplitCheck()
        {
            if (PlayerCardsList[0].GetValue() == PlayerCardsList[1].GetValue())
                return true;

            return false; 
        }
        /// <summary>
        /// Начало игры: игроку и дилеру дается 2 карты  
        /// </summary> 
        public void GameStart()   
        { 
            _deck.Shuffle(CardCount); //перемешиваем колоду и берем из нее 11 карт
             
            PlayerAddCard();
            PlayerAddCard();  
              
            DealerAddCard(); 
            DealerAddCard(); //игроку и дилеру дается по одной карте   
        }
        public void GameStartForPlayer()
        {
            _deck.Shuffle(CardCount); //перемешиваем колоду и берем из нее 11 карт 

            PlayerAddCard(); 
            PlayerAddCard(); 

        }


       /* public void PlayOptimal() 
        { 
            _deck.Shuffle(CardCount);

            while (_deck.HasCards()) 
            {
                // dealer play
                _deck.PickCard();
            }
        }*/ 

        /// <summary>
        /// Ход дилера
        /// </summary>
        /// <returns></returns>
        public void DealerMove()
        {
             
            if (totalplayer > 21)
            {
                //do nothing
            }
            else if (totaldealer == 16)
            {
                //do nothing too
            }
            else 
            {
                while (totaldealer < 17)
                {
                    DealerAddCard();
                }
            }

            EndCheck();
            EndMessage(); 
        }
        /// <summary>
        /// Ход дилера при сплите
        /// </summary>
        /// <returns></returns>
        public void SplitDealerMove() 
        {

            if (totaldealer == 16)
            {
                //do nothing   
            }
            else
            {
                while (totaldealer < 17)
                {
                    DealerAddCard();
                }
            }

            EndCheck();
            EndMessage();
        }


        /// <summary>
        /// Перебор у игрока  
        /// </summary>
        /// <returns></returns>
        public bool IsOverflow()
        {
            if (totalplayer > 21 & !HasA())
            {
                Statistic.AddDealerWin(); 
                return true;
            } 
             
            return false;   
             
        } 
          
        /// <summary>
        /// Взять карту
        /// </summary>
        /// <returns></returns>
        public void Hit()
        {
            PlayerAddCard();
 
            if (totalplayer > 21 & HasA()) //если сумма очков больше 21 и в колоде игрока имеется туз
            {
                foreach (var CurrentCard in PlayerCardsList) //проходим по картам чтобы найти туз
                {
                    if (CurrentCard.Number == 11) //если туз
                    {
                        CurrentCard.Number = 1; //присвоим значение 1  
                        totalplayer -= 10; 
                    }
                }  
            }  

        } 
         

    }  
   
} 
 