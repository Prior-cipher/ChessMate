using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    
    abstract public class Figure
    {
        public bool black;


        public bool nomoved;

        public int y;
        public int x;
        public bool blocked=false;

        public abstract List<Cell> CanMove(ref Cell[,] table);
        public abstract List<Cell> CanEat(ref Cell[,] table);
       


    }
}
