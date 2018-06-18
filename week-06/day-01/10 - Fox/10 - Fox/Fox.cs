using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Fox
{
    class Fox
    {
        string name;
        string type;
        string color;

        public Fox()
        {
        }

        public Fox(string name, string type, string color)
        {
            this.Name = name;
            this.Type = type;
            this.Color = color;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Color { get => color; set => color = value; }
    }
}
