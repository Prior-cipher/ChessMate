using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    public enum FigType { peshka, ladia, kon, slon, ferz, korol }
    abstract public class Figure
    {
        public bool black;


        public FigType figura;
        public int y;
        public int x;

        public abstract List<int> CanMove();
       


    }
}
