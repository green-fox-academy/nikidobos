using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_It
{
    class Postit
    {
        public string backgroungColor;
        public string text;
        public string textColor;

        public Postit(string backgroungColor, string text, string textColor)
        {
            this.backgroungColor = backgroungColor;
            this.text = text;
            this.textColor = textColor;
        }
    }
}
