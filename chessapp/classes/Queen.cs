using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessapp.classes
{
    public class Queen : BaseClass
    {
        public Queen(int x, int y) : base(x, y) { }

        public override bool Attack(BaseClass  other)
        {
            return (X == other.X || Y == other.Y || Math.Abs(other.X - X) == Math.Abs(other.Y - Y));
        }
    }
}
