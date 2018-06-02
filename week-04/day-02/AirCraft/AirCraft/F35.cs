using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class F35 : Aircraft
    {
        //        F16
        //  Max ammo: 8
        //Base damage: 30
        //F35 may ammo 12

        public F35() : base(12, 50, 0)
        {

        }

        public override string GettingType()
        {
            return "Type F35";
        }

        public override bool IsPriority()
        {
            return true;
        }
    }
}

