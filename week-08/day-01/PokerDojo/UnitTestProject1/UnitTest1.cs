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
    }
}
