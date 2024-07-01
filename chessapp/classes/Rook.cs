using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessapp.classes
{
    public class Rook : BaseClass //ладья
    {
        public Rook(int x, int y) : base(x, y) { }

        public override bool Attack(BaseClass other)
        {
            return (X == other.X || Y == other.Y); //вертикально и горизонтально
        }
    }
}
