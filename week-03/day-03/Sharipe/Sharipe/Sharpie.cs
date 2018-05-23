using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharipe
{
    class Sharpie
    {
        //Create Sharpie class
        //We should know about each sharpie their Color(which should be a string), 
        //Width(which will be a floating point number), InkAmount(another floating point number)
        //When creating one, we need to specify the Color and the Width
        //Every sharpie is created with a default 100 as InkAmount
        //We can Use() the sharpie objects
        //which decreases inkAmount

        public string color;
        public float width;
        public float inkamount = 100f;

        public Sharpie(string color, float width)
        {
            this.color = color;
            this.width = width;
        }

        public void Use()
        {
            inkamount--;
        }
    }
}
