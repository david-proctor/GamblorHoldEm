using System;
using System.Collections.Generic;

namespace HoldEm
{
    public class Deck : IDeck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    cards.Add(new Card(value, suit));
                }
            }
        }

        public Card Draw()
        {
            if(cards.Count < 1)
            {
                throw new EmptyDeckException("There are no cards left in this deck");
            }

            var rand = new Random();
            var card = cards[rand.Next(cards.Count)];
            cards.Remove(card);
            return card;
        }


    }
}
