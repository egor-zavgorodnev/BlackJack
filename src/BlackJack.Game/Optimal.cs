using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Optimal   
    {
        //private static int[] c = new int[] { 10, 7, 4, 2, 9, 6 };

        public List<int> c = new List<int>() { 10, 7, 4, 2, 2, 6 }; 

        //private static int[] c = new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };


        private List<int> BJList = new List<int>(); 

        private int player = 0; 
        private int dealer = 0;
         

        private int cmp(int player1 ,int player2)
        {
            if ((player1 <= 21 & player1 > player2) || player2 > 21)
            {
                return 1; //победа игрока 
            }

            return -1;
        }

        private int BJ(int i)
        {


            int n = c.Count - i;
 
            if (BJList.Contains(i)) 
                return BJList[i];
             
            List<int> options = new List<int>() { 0 };
            
            if (n - i < 4) 
            {
                System.Console.WriteLine("No Enough Cards!");
                return 0;
            }
            foreach (var p in Enumerable.Range(2, n - i - 2)) 
            { 
                player = c[i] + c[i + 2];
                /* 
                 * Ошибка скорее всего в строчке ниже
                 * Аналогия на пайтоне  - sum(c[i+4:i+p+2])  
                 * выдает при первой итерации sum(c[4:4]) = 0. 0 прибавляется к первым двум картам
                 * А цикл ниже на си-шарпе какого то хуя прибавляет элемент с[4] 
                 * Крч, если в консоли первая запись будет равна player=14 , вместо 16 то все збс
                 * */
                if (p == 2)
                {
                    System.Console.WriteLine("Player=" + player);
                }
                else {
                    for (int j = 4; j <= p + 2; j++)
                    {
                        player += (c[i + j]);
                        System.Console.WriteLine("Player=" + player);
                    };
                }
                if (player > 21) 
                {
                    System.Console.WriteLine("Player Bust");
                    options.Add(-1 + BJ(i + p + 2));
                    break;
                }
                dealer = 0;
                int d1 = 0; 
                foreach (var d in Enumerable.Range(2,n - i - p))
                {
                    d1 = d;
                    dealer = c[i + 1] + c[i + 3];
                    for (int j = p + 2; j < i + p + d; j++) { dealer += c[i + j]; }
                    System.Console.WriteLine("Dealer=" + dealer);
                    if (dealer >= 17)
                    {
                        System.Console.WriteLine("Dealer Stop Drawing");
                        break;
                    }
                }
                if (dealer > 21) 
                {
                    System.Console.WriteLine("Dealer Bust");
                    dealer = 0;
                }
                System.Console.WriteLine("Dealer=" + dealer);

                options.Add(cmp(player, dealer) + BJ(i + p + d1)); 
            }
            BJList.Add(options.Max()); 
            return options.Max();
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

    }  
}
