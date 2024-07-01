using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    public abstract class BaseClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public BaseClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract bool Attack(BaseClass other);
    }
}