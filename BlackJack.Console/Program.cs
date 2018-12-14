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
            Optimal opt = new Optimal();
             
            System.Console.WriteLine("Количество побед: " + opt.GetWinsCount());

            System.Console.WriteLine("Ходы игрока: " + opt.GetStrategy());
           System.Console.WriteLine("Побед дилера: " + opt.dealer_wins);
            System.Console.WriteLine("Побед игрока : " + opt.player_wins);
            System.Console.WriteLine("Ничьих: " + opt.draws);

            int[] c = new int[] {  1, 2, 3, 4, 6, 7 };
            int player = 0;
            int n = 6;
            int i = 0;
            for (int p = 2,j=4; p < n - i; p++)
            {
                player = c[i] + c[i + 2];
                
                    for (j = 4; j <= p + 2 && j < c.Length; j++)
                    { 
                      
                        player += (c[i + j]);
                   
                    };
                
              //  System.Console.WriteLine("ПЭ " + p);
            }
           // System.Console.WriteLine("Player " + player);

            System.Console.ReadKey();

            
            /* var deck = new CardDeck();
             
             var card = new Card(); 
             card.Number = Card.GetPictureNumber(CardPicture.K);
             // card.Number = 10;
             card.Color = CardColor.Spades;

             PrintCard(card);

             for (int i = 0; i < 3; i++)
             { 
                 deck.Shuffle(11 + i);

                 System.Console.WriteLine("Play deck of " + deck.CardCount() + " cards:");

                 while (deck.HasCards())
                 {
                     card = deck.PickCard();
                     PrintCard(card);
                 }

                 System.Console.WriteLine("--- // ---");
                 System.Console.WriteLine("Well done!");
             }
             System.Console.ReadKey();*/
        } 
    }
}
