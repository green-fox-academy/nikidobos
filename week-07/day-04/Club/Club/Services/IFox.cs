using Club.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Club.Services
{
    public interface IFox
    {
        void AddFox(string name);
        Fox GetFox(string name);
        string TeachTricks();
        string FeedTheFox();
    }
}
