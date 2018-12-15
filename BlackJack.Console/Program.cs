using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;

namespace BlackJack.Console
{
    class Program 
    {  
        static void Main(string[] args)     
        { 
            Optimal opt = new Optimal(new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });

            System.Console.WriteLine("Количество побед: " + opt.GetWinsCount());

            /*System.Console.WriteLine("Ходы игрока: " + opt.GetStrategy());
            System.Console.WriteLine("Побед дилера: " + opt.dealer_wins); 
            System.Console.WriteLine("Побед игрока : " + opt.player_wins); 
            System.Console.WriteLine("Ничьих: " + opt.draws);*/
             
            System.Console.ReadKey();

            /* Пожилая змея */

//import sys
//import string 
//import math
//import os
//import struct
//import random


//i = 0
//p = 2 
 
//#c = [1, 2, 3, 4, 6, 7]
//#c = [10, 7, 4, 2, 7, 6]  
//#c = [10,10,10,10,8]  
//#c = [10,10,10,10,8,9,2]   
//c = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1]

//        n=len(c)


//dealer = 0
  
//d1=0;

//for p in range(2, (n - i)):                                                                                                                                             
//      player = c[i] + c[i + 2] + sum(c[i + 4:i + p + 2])
//      print(p)
//print(player)

//# for d in range(2,n-i-p+1):     
//# print(d)
//# d1 = d                                                                                                                                                                                       
//# dealer = c[i+1] + c[i+3] + sum(c[i+p+2:i+p+d])                                                                                                                                                                                                                                                                                                                           
//#if dealer >= 17:                                                                                                                                                                            
//# break                               # breaks out of for(d)                                                                                                                              
//#if dealer < 17 and i + p + d1 >= n:                                                                                                                             
//# dealer = 21                                                                                                                                          
//#if dealer > 21:                                                                                                                                                                              
//# dealer = 0     
//# print("DEALER=",dealer)                                                                                                                                                                                 
//# dealer += .5                                    # dealer always wins in a tie     



            /*foreach p*/ 
              
            ////int[] c = new int[] {  1, 2, 3, 4, 6, 7 };
            ////int[] c = new int[] {  10, 7, 4, 2, 7, 6 };
            ////int[] c = new int[] {  10,10,10,10,8,9,2 };
            //int[] c = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            //int player = 0;
            //int n = c.Length; 
            //int i = 0;
            //for (int p = 2; p < n - i; p++)
            //{
            //    player = c[i] + c[i + 2];

            //    if (p != 2)
            //    {
            //        for (int j = 4; j <= p + 2 && j < c.Length; j++)
            //        {
            //            player += c[i + j];
            //        };
            //    }
            //    System.Console.WriteLine("ПЭ " + p);
            //}
            //System.Console.WriteLine("Player " + player);

            //System.Console.ReadKey();



             

            /*foreach d*/

            ////int[] c = new int[] { 1, 2, 3, 4, 6, 7 };
            ////int[] c = new int[] {  10, 7, 4, 2, 7, 6 };
            ////int[] c = new int[] {  10,10,10,10,8 }; 
            //int[] c = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

            //int n = c.Length; 
            //int i = 0;
            //int p = 2;
            //int d1 = 0;

            //double dealer = 0;

            //for (var d = 2; d <= n - i - p; d++) /*foreach (var d in Enumerable.Range(2,n - i - p))*/
            //{
            //    System.Console.WriteLine(d);
            //    d1 = d;
            //    dealer = c[i + 1] + c[i + 3];

            //    if (d != 2)
            //    {
            //        for (int j = p + 2; j <= p + d && j < n; j++)
            //        {
            //            dealer += c[i + j];
            //        }
            //    }
            //    //Console.WriteLine("Dealer = " + dealer);
            //    if (dealer >= 17)
            //    {
            //        // Console.WriteLine("Dealer Stop Drawing");
            //        break;
            //    }
            //}
            //if (dealer < 17 && i + p + d1 >= n)
            //{
            //    dealer = 21;
            //}
            //if (dealer > 21)
            //{
            //    dealer = 0;
            //    //Console.WriteLine("Dealer Bust");
            //}
            //System.Console.WriteLine("Dealer = " + dealer);
            //dealer += 0.5;

            //System.Console.ReadKey();  



        }
    }
}
