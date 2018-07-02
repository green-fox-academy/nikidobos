using System;
using System.Collections;
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
            try
            {
                int parsed = Int32.Parse(input[0].ToString());
                return parsed;
            }
            catch (Exception)
            {

                if (input == "J")
                {
                    return 11;
                }

                else if (input == "Q")
                {
                    return 12;
                }

                else if (input == "K")
                {
                    return 13;
                }

                else if (input == "A")
                {
                    return 14;
                }
                return 0;
            }
        }

        public static int GetSumOfCards(string[] cards)
        {
            int sum = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                sum += Int32.Parse(cards[i][0].ToString());
            }
            return sum;
        }
    }
}

