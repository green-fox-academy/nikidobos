﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class CounterService : ICounter
    {
        private int countOfClicks;
        public int GetNumber()
        {
            return countOfClicks;
        }

        public void Increase()
        {
            countOfClicks++;
        }
    }
}
