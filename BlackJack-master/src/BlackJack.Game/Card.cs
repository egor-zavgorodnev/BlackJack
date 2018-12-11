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

    
   
} 
 