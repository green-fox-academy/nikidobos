﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greet_Someone.Services
{
    public interface IGreet
    {
        string Greet();
        void SetName(string input);
    }
}
