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

    public class Game
    { 
         
        public int totaldealer = 0; //сумма очков дилера
        private int totalplayer = 0; //сумма очков игрока  

        public string DealerCards; //карты дилера в строке 
  
        public static List<Card> PlayerCardsList = new List<Card>(); //список карт игрока , статический список для главной игры

        public static List<Card> DealerCardsList = new List<Card>(); //список карт дилера , статический список для главной игры
        public List<Card> DealerSplitCardsList = new List<Card>(); //список карт дилера в сплите
            
        public List<Card> PlayerCardsList_Split1 = new List<Card>(); //список карт игрока для сплита1 

        public List<Card> PlayerCardsList_Split2 = new List<Card>(); //список карт игрока для сплита2 
         
        public string PlayerCards; //карты игрока в строке  
         
        //первая и вторая карта игрока (для сплита)
        public Card PlayerFirstCard{ get { return PlayerCardsList[0];} }  
        public Card PlayerSecondCard { get { return PlayerCardsList[1]; } }

        //первая и вторая ката дилера (для сплита)  
        public Card DealerFirstCard { get { return DealerCardsList[0]; } }
        public Card DealerSecondCard { get { return DealerCardsList[1]; } }

          
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
        public void DealerAddCard(List<Card> CurrentCardsList)
        { 
            Card newcard = _deck.PickCard();   
            
            totaldealer += newcard.GetValue();

            CurrentCardsList.Add(newcard); 

            DealerCards += newcard.GetCaption() + " ";

            if (totaldealer > 21 & DealerHasA()) //если сумма очков больше 21 и в колоде игрока имеется туз
            {
                foreach (var CurrentCard in DealerCardsList) //проходим по картам чтобы найти туз
                {
                    if (CurrentCard.Number == 11) //если туз
                    {
                        CurrentCard.Number = 1; //присвоим значение 1  
                        totaldealer -= 10;
                    }
                }
            }  
        }
          
        /// <summary> 
        /// Игроку дается одна карта 
        /// </summary> 
        public void PlayerAddCard(List<Card> CurrentCardList) 
        {
            Card newcard = _deck.PickCard();
             
            totalplayer += newcard.GetValue();
             
            CurrentCardList.Add(newcard); 
             
            PlayerCards += newcard.GetCaption() + " "; 
        }
          
        /// <summary>
        /// Есть ли туз среди карт игрока  
        /// </summary>
        /// <returns></returns> 
        public bool PlayerHasA()  
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
        /// Есть ли туз среди карт игрока  
        /// </summary>  
        /// <returns></returns> 
        public bool DealerHasA()
        {
            foreach (var CurrentCard in DealerCardsList)
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
            PlayerCardsList_Split1.Clear();
            PlayerCardsList_Split2.Clear();

            DealerSplitCardsList.Clear();
            DealerCardsList.Clear();

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

            PlayerAddCard(PlayerCardsList);
            PlayerAddCard(PlayerCardsList);   
               
            DealerAddCard(DealerCardsList);  
            DealerAddCard(DealerCardsList); //игроку и дилеру дается по одной карте   

            if (GetTotalDealer() == 22)
                totaldealer = 2;
        }
         
        /// <summary>
        /// Начало 1 игры сплита
        /// </summary>
        public void SplitGame1Start()
        {
            _deck.Shuffle(CardCount); //перемешиваем колоду и берем из нее 11 карт  

            //добавляем карты из основной игры в сплит-колоды 
            PlayerCardsList_Split1.Add(PlayerFirstCard);

            // Берем карту из главной игры
            totalplayer += PlayerFirstCard.GetValue();
            PlayerCards += PlayerFirstCard.GetCaption() + " ";


            PlayerAddCard(PlayerCardsList_Split1);

            if (GetTotalDealer() == 22)
                totaldealer = 2;

        }  
        /// <summary>
        /// Начало 2 игры сплита 
        /// </summary>
        public void SplitGame2Start()   
        {
            _deck.Shuffle(CardCount); //перемешиваем колоду и берем из нее 11 карт   

            //добавляем карты из основной игры в сплит-колоды 
            PlayerCardsList_Split2.Add(PlayerSecondCard);

            DealerSplitCardsList.Add(DealerFirstCard);
            DealerSplitCardsList.Add(DealerSecondCard);
             
            // Берем карту из главной игры  
            totalplayer += PlayerSecondCard.GetValue();
            PlayerCards += PlayerSecondCard.GetCaption() + " ";
             
            //Берем карты для дилера из главной игры 
            totaldealer += DealerFirstCard.GetValue();
            DealerCards += DealerFirstCard.GetCaption() + " ";

            totaldealer += DealerSecondCard.GetValue();
            DealerCards += DealerSecondCard.GetCaption() + " ";
                      

            PlayerAddCard(PlayerCardsList_Split2); 

            if (GetTotalDealer() == 22)
                totaldealer = 2; 
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
                    DealerAddCard(DealerCardsList);
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
                    DealerAddCard(DealerSplitCardsList); 
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
            if (totalplayer > 21 & !PlayerHasA()) 
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
        public void Hit(List<Card> CurrentCardList)
        {
            PlayerAddCard(CurrentCardList);
 
            if (totalplayer > 21 & PlayerHasA()) //если сумма очков больше 21 и в колоде игрока имеется туз
            {
                foreach (var CurrentCard in CurrentCardList) //проходим по картам чтобы найти туз
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
 