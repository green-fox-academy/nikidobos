using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club.Services
{
    public interface IFox
    {
        void TeachTricks(string trick);
        void FeedTheFox(string food);
        void DrinkTheFox(string drink);
    }
}
