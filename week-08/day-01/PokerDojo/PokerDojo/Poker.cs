using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerDojo
{
    public class Poker
    {
        string[] blackCards = { "2H", "3D", "5S", "9C", "KD" };
        string[] whiteCards = { "2C", "3H", "4S", "8C", "AH" };

        public static int GetValue(string input)
        {
            int parsed = Int32.Parse(input);
            return parsed;
        }

    }
}
