using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    public class Cell
    {
        public int x;
        public int y;
        public Figure fig;
        public bool enemy;
        public Cell(int y,int x,Figure fig)
        {
            this.y = y;
            this.x=x;
            
            this.fig=fig;
           
        }
        public override string ToString()
        {
            return string.Join(" ",this.x,this.y,this.fig);
        }
    }
}
