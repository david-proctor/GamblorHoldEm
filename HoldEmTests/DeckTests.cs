using System;
using System.Collections.Generic;
using HoldEm;
using NUnit.Framework;

namespace HoldEmTests
{
    [TestFixture]
    class DeckTests
    {
        protected Deck Q;

        [SetUp]
        public void SetUp()
        {
            Q = new Deck();
        }

        [Test]
        public void Ctor_Returns52CardDeck()
        {
            Assert.AreEqual(52, Q.cards.Count);
        }

        [Test]
        public void Ctor_ReturnsAllUniqueCards()
        {
            CollectionAssert.AllItemsAreUnique(Q.cards);
        }

        [Test]
        public void Draw_ReturnsUniqueCards()
        {
            List<Card> drawnCards = new List<Card>();
            for(var i = 0; i < 52; ++i)
            {
                drawnCards.Add(Q.Draw());
            }

            CollectionAssert.AllItemsAreUnique(drawnCards);
        }

        [Test]
        [ExpectedException(typeof(EmptyDeckException))]
        public void Draw_ThrowsOnEmptyDeck()
        {
            for(var i = 0; i < 53; ++i)
            {
                Q.Draw();
            }
        }
    }
}
