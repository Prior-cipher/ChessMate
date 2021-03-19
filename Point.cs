using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    public class Point
    {
        public int x;
        public int y;
        public bool fig;
        public bool enemy;
        public Point(int x,int y,bool fig,bool enemy)
        {
            this.x=x;
            this.y=y;
            this.fig=fig;
            this.enemy=enemy;
        }
        public override string ToString()
        {
            return string.Join(" ",this.x,this.y,this.fig,this.enemy);
        }
    }
}
