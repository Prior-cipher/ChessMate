using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Ladia:Figure
    {
        public Ladia(bool black, int y, int x)
        {
            this.black = black;
            this.figura = FigType.ladia;
            this.y = y;
            this.x = x;
        }

        public override List<int> CanMove() 
        {


            return new List<int>();
        }
    }
}
