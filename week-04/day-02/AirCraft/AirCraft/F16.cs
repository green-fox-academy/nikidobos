using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class F16 : Aircraft
    {
        bool isPriority = false;

        public F16() : base(8, 30, 0)
        {

        }

        public override string GettingType()
        {
            return "Type F16";
        }

        public override bool IsPriority()
        {
            return false;
        }
    }
}

