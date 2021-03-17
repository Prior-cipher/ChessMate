using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Peshka:Figure
    {
        public Peshka(bool black, int y, int x)
        {
            this.black = black;
            this.figura = FigType.peshka;
            this.y = y;
            this.x = x;
        }

        public override List<int> CanMove()
        {


            return new List<int>();
        }

    }
}
