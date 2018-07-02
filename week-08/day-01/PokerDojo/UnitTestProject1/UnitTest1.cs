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
    }
}
