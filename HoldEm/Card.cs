using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoldEm
{
    public enum Suit
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades
    }

    public enum CardValue
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public sealed class Card
    {
        public Card(CardValue value, Suit suit)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit
        {
            get;
            private set;
        }

        public CardValue Value
        {
            get;
            private set;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Value, Suit);
        }

        public override bool Equals(Object other)
        {
            if (other == null || !(other is Card))
            {
                return false;
            }
            Card otherCard = other as Card;

            return (Suit == otherCard.Suit) && (Value == otherCard.Value);
        }

        public static bool operator ==(Card a, Card b)
        {
            if ((Object)a == null || (Object)b == null)
            {
                return false;
            }
            return (a.Value == b.Value) && (a.Suit == b.Suit);
        }

        public static bool operator !=(Card a, Card b)
        {
            return !(a == b);
        }
    }
}
