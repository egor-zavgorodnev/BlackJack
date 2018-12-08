using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Optimal
    {
        public CardDeck deck = new CardDeck();

        public int WinsCount { get { return GetWinsCount(); } }

        private static int cmp(int player1, int player2) 
        {
            if ((player2 <= 21 & player2 > player1) || player1 > 21)
            {
                return -1; //победа дилера  
            }
            if ((player1 <= 21 & player1 > player2) || player2 > 21)
            {
                return 1; //победа игрока  
            }

            return 0; //ничья 
        }

        private int GetValue(int Number)
        {
            if (Number > 11)
            {
                return 10;
            }
            return Number;
        }

        private int BJ(int i)
        { 
            
            int player = 0;
            int dealer = 0;  
            int n = 52;
               
            List<int> options = new List<int>(); 

            if (n - 1 < 4) return 0; // т.к. нет больше карт для игры

            foreach (var p in Enumerable.Range(2, n - i - 2)) // цикл по всем картам
            {
                int D = 0;
                // Дилер раздает - сначала игроку, потом себе, потом игроку...
                player = GetValue( deck.PickCard(i).Number ) + deck.PickCard(i + 2).Number;
                for (var j = 4; j <= i + p + 2; j++) player += GetValue(deck.PickCard( i + j ).Number);
                if (player > 21)  // перебор у игрока
                {
                    options.Add(-1 + BJ(i + p + 2));  
                    break;    
                }
                foreach (var d in Enumerable.Range(2, n - i - p)) 
                {
                    player = GetValue(deck.PickCard(i + 1).Number) + deck.PickCard(i + 3).Number;
                    for (var j = p + 2; j <= i + p + d; j++)
                    { 
                        dealer += GetValue(deck.PickCard(i + j).Number); 
                    }
                    D = d;  
                    if (dealer >= 17) break; 
                } 
                if (dealer > 21) dealer = 0; // перебор у дилера
                options.Add(cmp(player, dealer) + BJ(i + p + D));
            }
            return options.Max();
        } 

        public int GetWinsCount()
        { 
            int count = 0;
             
            deck.Shuffle(52);

            for (int i = 0; i < 52; i++) 
            { 
                if (deck.CardCount() > 11)
                    count += BJ(i); 
            }  
          
               
            return count;      
                
        }  
         

    } 
}
