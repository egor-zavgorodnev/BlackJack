using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Optimal    
    {
        public Optimal(List<int> cards)
        {
            c = cards;
        } 

        //public List<int> c = new List<int>() { 10, 7, 4, 2, 7, 6 }; //true 
        //public  List<int> c;
        // public List<int> c = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
        public List<int> c;    
        //public List<int> c = new List<int>() { 10,10,10,10,8};

        // public List<int> c = new List<int>(){ 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

        List<int> options = new List<int>() { 0 };

        public string way = "";

        private List<int> BJList = new List<int>();  

        

        private double player = 0; 
        private double dealer = 0;
        public int dealer_wins = 0;
        public int draws = 0;
        public int player_wins = 0;

        //private int cmp(double player1, double player2)
        //{
        //    if ((player2 <= 21 && player2 > player1) || player1 > 21)
        //    {
        //        dealer_wins++;

        //        return -1; //победа дилера  
        //    }
        //    if ((player1 <= 21 && player1 > player2) || player2 > 21)
        //    {
        //        player_wins++;
        //        return 1; //победа игрока  
        //    }
        //    draws++;
        //    return 0; //ничья
        //}

        private int cmp(double a, double b)
        {
            double var1=0;
            double var2=0;

            if (a > b) var1 = 1;
            
            if (a < b) var2 = 1; 
            int abs = Convert.ToInt32(var1 - var2);
            if (abs ==1) player_wins++;
            if (abs == -1) dealer_wins++;
            if (abs == 0) draws++;
            return Convert.ToInt32(var1 - var2);
        }
 
        private int BJ(int i)  
        {
            if (BJList.Contains(i)) return BJList[i];
               
            int n = c.Count; 
              
            Console.WriteLine(n);
            if (n - i < 4)  
            {
                //Console.WriteLine("No Enough Cards!");
                return 0;
            }
            for (var p = 2; p < n - i; p++) //true
            {
                player = c[i] + c[i + 2]; 
                if (p != 2)    
                {
                    for (int j = 4; j <= p + 2 && j < n - i; j++)
                        { 
                            player += c[i + j];   
                        };     
                }   
               // Console.WriteLine("Player = " + player);  
                if (player > 21)    
                {  
                    options.Add(-1 + BJ(i + p + 2));
                    //Console.WriteLine("Player Bust"); 
                    break;
                }    
                 dealer = 0;
                 int d1 = 0;   
                 for (var d = 2; d <= n - i - p ; d++) /*foreach (var d in Enumerable.Range(2,n - i - p))*/
                 {  
                    d1 = d;      
                    dealer = c[i + 1] + c[i + 3];
                      
                    if (d != 2)  
                    { 
                        for (int j = p + 2; j <= p + d && j < n - i; j++)
                        {
                            dealer += c[i + j];  
                        } 
                    }
                    //Console.WriteLine("Dealer = " + dealer);
                    if (dealer >= 17)  
                    {
                       // Console.WriteLine("Dealer Stop Drawing");
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
                    //Console.WriteLine("Dealer Bust");
                }
                //Console.WriteLine("Dealer = " + dealer);
                dealer += 0.5;
                options.Add(cmp(player, dealer) + BJ(i + p + d1));
            }   
            BJList.Add(options.Max());
            return options.Max();  
        }

        private string StrategyBJ(int i)
        {
            int n = c.Count ;

            if (n - i < 4)
            {
                //Console.WriteLine("No Enough Cards!");
                return "";
            } 
            for (var p = 2; p <= n - i; p++) /*foreach(var p in Enumerable.Range(2,n-i-2)) */
            {
                player = c[i] + c[i + 2];

                if (p != 2)
                {
                    for (int j = 4; j <= p + 2 && j < n; j++)
                    {
                        player += (c[i + j]);
                        way += "H"; 
                    };
                }
                //Console.WriteLine("Player = " + player);

                if (player > 21)
                {
                   BJ(i + p + 2);
                   // Console.WriteLine("Player Bust");
                    break;
                }
                dealer = 0; 
                int d1 = 0;
                way += "S";
                for (var d = 2; d <= n - i - p; d++) /*foreach (var d in Enumerable.Range(2,n - i - p))*/
                {
                    d1 = d;
                    dealer = c[i + 1] + c[i + 3];

                    for (int j = p + 2; j <= p + d && j < n; j++)
                    {
                        dealer += c[i + j];
                    }

                   // Console.WriteLine("Dealer = " + dealer); 
                    if (dealer >= 17)
                    {
                        //Console.WriteLine("Dealer Stop Drawing");
                        break;
                    }
                }
                if (dealer > 21)
                {
                    dealer = 0; 
                    //Console.WriteLine("Dealer Bust");
                }
                //Console.WriteLine("Dealer = " + dealer);
                BJ(i + p + d1);
              
            }
            return way;
        }

        public int GetWinsCount() 
        { 
             
            System.Console.WriteLine("Array:"); 
            for (int i = 0; i < c.Count; i++)
            {
                System.Console.Write(c[i] + " "); 
            } 
            System.Console.WriteLine(); 
              
            return BJ(0); 
        }


        public string GetStrategy()
        { 
            return StrategyBJ(0);
        }
         
        
    }  
} 
