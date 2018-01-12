using System;
using System.Collections.Generic;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Speed { get; set; }

        public void Walk()
        {
            Speed = 3;
        }
    }
}
