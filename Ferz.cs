using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Ferz:Figure
    {
        public Ferz(bool black, int y, int x)
        {
            this.black = black;

            this.y = y;
            this.x = x;
        }

        public override List<Point> CanMove(ref List<Figure> figures)
        {


            return new List<Point>();
        }
        public override List<Point> CanEat(ref List<Figure> figures) { return new List<Point>(); }
    }
}
