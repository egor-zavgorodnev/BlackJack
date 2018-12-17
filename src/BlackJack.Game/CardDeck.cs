using System;
using System.Collections.Generic;

namespace BlackJack
{
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

        public static int GetCardCount { get; private set;}



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
            //initialDeck = Create_52_deck(); 
            cards = new List<Card>();
             
            for (int i = 0; i < cardCount; i++) 
            {
                var index = rnd.Next(0, initialDeck.Count - 1);
                var card = initialDeck[index];
                cards.Add(card); 
                initialDeck.RemoveAt(index);
            }
            GetCardCount = initialDeck.Count;
        }

          public void Shuffle_new_deck()
          {
            initialDeck = Create_52_deck();
            GetCardCount = initialDeck.Count;
          } 


        public Card PickCard() 
        {
            CheckNotEmpty();  

            var card = cards[0]; 
            cards.RemoveAt(0);
            return card;
        }
         
        public Card PickCard(int i)
        {
            CheckNotEmpty(); 
              
            var card = cards[i]; 
            //cards.RemoveAt(i);
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
}