using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PokerDojo;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("2")]
        public void IfCardIsTwoReturnTwo(string input)
        {
            int parsed = Poker.GetValue(input);
            NUnit.Framework.Assert.AreEqual(2, parsed);
        }

        [TestCase("J")]
        public void IfCardIsJackReturnEleven(string input)
        {
            int parsed = Poker.GetValue(input);
            NUnit.Framework.Assert.AreEqual(11, parsed);
        }

        [TestCase("Q")]
        public void IfCardIsQueenReturnTwelve(string input)
        {
            int parsed = Poker.GetValue(input);
            NUnit.Framework.Assert.AreEqual(12, parsed);
        }

        [TestCase("K")]
        public void IfCardIsKingReturnThirteen(string input)
        {
            int parsed = Poker.GetValue(input);
            NUnit.Framework.Assert.AreEqual(13, parsed);
        }

        [TestCase("A")]
        public void IfCardIsAceReturnFourteen(string input)
        {
            int parsed = Poker.GetValue(input);
            NUnit.Framework.Assert.AreEqual(14, parsed);
        }

        [TestCase("2H")]
        public void IfCardIs2HReturn2(string input)
        {
            int parsed = Poker.GetValue(input);
            NUnit.Framework.Assert.AreEqual(2, parsed);
        }

        [TestCase(new object[] { new string[] { "2H", "3D", "5S", "9C" } })]
        public void ShouldReturnNineteen(string[] cards)
        {
            int sum = Poker.GetSumOfCards(cards);
            NUnit.Framework.Assert.AreEqual(19, sum);
        }
    }
}

