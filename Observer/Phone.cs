﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Phone : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Phone received update: {message}");
        }
    }
}
