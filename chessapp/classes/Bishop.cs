using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessapp.classes
{
    public class Bishop : BaseClass // слон
    {
        public Bishop(int x, int y) : base(x, y) { }

        public override bool Attack(BaseClass other)
        {
            return Math.Abs(other.X - X) == Math.Abs(other.Y - Y); //диагональ
        }
    }
}
