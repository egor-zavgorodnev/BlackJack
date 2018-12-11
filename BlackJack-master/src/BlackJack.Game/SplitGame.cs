using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class SplitGame : Game
    {
        public SplitGame() : base()
        {
             
        }

        public List<Card> DealerSplitCardsList = new List<Card>(); //список карт дилера в сплите

        public List<Card> PlayerCardsList_Split1 = new List<Card>(); //список карт игрока для сплита1 

        public List<Card> PlayerCardsList_Split2 = new List<Card>(); //список карт игрока для сплита2 

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
    }
}
