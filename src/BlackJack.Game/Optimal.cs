using System;
using System.Collections.Generic;
using System.Linq;


namespace BlackJack
{
    /// <summary>
    /// Оптимальная игра: максимизация выигрыша игрока при известной колоде 
    /// </summary>
    public class Optimal
    {
        /// <summary>
        /// Замешивание колоды с определенным количеством карт
        /// </summary> 
        /// <param name="cardCount">Количество карт в игре</param>
        public Optimal(int cardCount)
        {
            deck.Shuffle(cardCount); 
        }

        /// <summary>
        /// Максимальный выигрыш игрока
        /// </summary>
        public int MaxReward
        {
            get 
            {
                return BJ(0);
            }
        }
          
        /// <summary>
        /// Стратегия игрока  
        /// </summary>
        public string Way
        {
            get
            {
                return StrategyBJ(0);
            }
            private set { }
        } 
         
        private CardDeck deck = new CardDeck();     
        private List<int> options = new List<int>() { 0 };
        private List<int> BJList = new List<int>();  
         
        private double player = 0;  
        private double dealer = 0;

     
        private int cmp(double a, double b)
        {
            double var1 = 0;
            double var2 = 0; 

            if (a > b) var1 = 1;    
            if (a < b) var2 = 1; 
              
            return Convert.ToInt32(var1 - var2);
        }
 
        private void ClearScopes()
        {
            player = 0;
            dealer = 0; 
        }

        private int BJ(int i)  
        {
            if (BJList.Contains(i)) return BJList[i];
               
            int n = deck.CardCount(); 
              
            if (n - i < 4)  
            {
                return 0;  
            }  
            for (var p = 2; p < n - i; p++) 
            {
                player = deck.PickCard(i).GetValue() + deck.PickCard(i + 2).GetValue(); 

                if (p != 2)    
                {
                    for (int j = 4; j <= p + 2 && j < n - i; j++)
                        { 
                            player += deck.PickCard(i + j).GetValue();   
                        };     
                }     
                if (player > 21)    
                {  
                    options.Add(-1 + BJ(i + p + 2));
                    break;
                }    
                 dealer = 0;
                 int d1 = 0;   
                 for (var d = 2; d <= n - i - p ; d++) 
                 {  
                    d1 = d;       
                    dealer = deck.PickCard(i + 1).GetValue() + deck.PickCard(i + 3).GetValue();
                      
                    if (d != 2)  
                    { 
                        for (int j = p + 2; j <= p + d && j < n - i; j++)
                        {
                            dealer += deck.PickCard(i + j).GetValue();  
                        } 
                    }
                    if (dealer >= 17)    
                    {
                        break;
                    }
                }
                if (dealer < 17 && i + p + d1 >= n )  
                {
                    dealer = 21;
                } 
                if (dealer > 21)    
                { 
                    dealer = 0;
                }
                dealer += 0.5;
                options.Add(cmp(player, dealer) + BJ(i + p + d1));
            }   
            BJList.Add(options.Max());
            return options.Max();  
        } 
         
        private string StrategyBJ(int i) 
        {
            ClearScopes();
             
            int n = deck.CardCount();
             
            if (n - i < 4)
            {
                return "";
            }
            for (var p = 2; p < n - i; p++)  
            {
                player = deck.PickCard(i).GetValue() + deck.PickCard(i + 2).GetValue();
                if (p != 2)
                {
                    for (int j = 4; j <= p + 2 && j < n - i; j++)
                    {
                        player += deck.PickCard(i + j).GetValue();
                        Way += "H";
                    };
                }
                if (player > 21)
                {
                    StrategyBJ(i + p + 2);
                    break;
                }
                dealer = 0; 
                int d1 = 0; 
                Way += "D";
                for (var d = 2; d <= n - i - p; d++)
                {
                    d1 = d;
                    dealer = deck.PickCard(i + 1).GetValue() + deck.PickCard(i + 3).GetValue();

                    if (d != 2)
                    {
                        for (int j = p + 2; j <= p + d && j < n - i; j++)
                        {
                            dealer += deck.PickCard(i + j).GetValue();
                        }
                    }
                    if (dealer >= 17)
                    {
                        break;
                    }
                }
                if (dealer < 17 && i + p + d1 >= n)
                {
                    dealer = 21;
                }
                if (dealer > 21)
                {
                    dealer = 0;
                } 
                dealer += 0.5;
                StrategyBJ(i + p + d1);
            }
            return Way; 
        }
         
       
         
        
    }  
} 
