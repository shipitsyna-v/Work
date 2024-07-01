using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessapp.classes
{
    public class King : BaseClass
    {
        public King(int x, int y) : base(x, y) { }

        public override bool Attack(BaseClass other)
        {
            int dx = Math.Abs(other.X - X);
            int dy = Math.Abs(other.Y - Y);
            return dx <= 1 && dy <= 1;
        }
    }
}
