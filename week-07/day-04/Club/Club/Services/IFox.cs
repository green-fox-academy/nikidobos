using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club.Services
{
    public interface IFox
    {
        void Login(string input);
        void LearnTricks(string trick);
        void FeedTheFox(string food, string drink);
    }
}
