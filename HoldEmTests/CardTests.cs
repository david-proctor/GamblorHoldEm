using System;
using HoldEm;
using NUnit.Framework;

namespace HoldEmTests
{
    [TestFixture]
    public class CardTests
    {
        private Card Q;

        [SetUp]
        protected void SetUp()
        {
            Q = new Card(CardValue.Ace, Suit.Spades);
        }

        [Test]
        public void ToString_Prints()
        {
            Assert.AreEqual("Ace of Spades", Q.ToString());
        }

        [Test]
        public void Equals_NullComparisonIsFalse()
        {
            Assert.IsFalse(Q.Equals(null));
        }
        
        [Test]
        public  void Equals_NonCardComparisonIsFalse()
        {
            Assert.IsFalse(Q.Equals(new Object()));
        }

        [Test]
        public void Equals_ComparesValues_SameWorks()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);
            var b = new Card(CardValue.Ace, Suit.Spades);

            Assert.IsTrue(a.Equals(b));
        }

        [Test]
        public void Equals_ComparesValues_DifferentWorks()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);
            var b = new Card(CardValue.Two, Suit.Hearts);

            Assert.IsFalse(a.Equals(b));
        }

        [Test]
        public void OperatorEq_NullComparisonIsFalse()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);

            Assert.IsFalse(a == null);
            Assert.IsFalse(null == a);
        }

        [Test]
        public void OperatorEq_SameWorks()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);
            var b = new Card(CardValue.Ace, Suit.Spades);

            Assert.IsTrue(a == b);
        }

        [Test]
        public void OperatorEq_DifferentWorks()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);
            var b = new Card(CardValue.Two, Suit.Hearts);

            Assert.IsFalse(a == b);
        }

        [Test]
        public void OperatorNEq_NullComparisonIsFalse()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);

            Assert.IsTrue(a != null);
            Assert.IsTrue(null != a);
        }

        [Test]
        public void OperatorNEq_SameWorks()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);
            var b = new Card(CardValue.Ace, Suit.Spades);

            Assert.IsFalse(a != b);
        }

        [Test]
        public void OperatorNEq_DifferentWorks()
        {
            var a = new Card(CardValue.Ace, Suit.Spades);
            var b = new Card(CardValue.Two, Suit.Hearts);

            Assert.IsTrue(a != b);
        }
    }
}
