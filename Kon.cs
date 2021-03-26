using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Kon:Figure
    {


        public Kon(bool black, int y, int x)
        {
            this.black = black;
            
            this.y = y;
            this.x = x;
        }
        public override List<Cell> CanMove(ref Cell[,] table)
        {


            return new List<Cell>();
        }
        public override List<Cell> CanEat(ref Cell[,] table) { return new List<Cell>(); }
    }
}
