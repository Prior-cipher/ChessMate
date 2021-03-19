using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Peshka:Figure
    {
        public bool doublehod=false;
        public Peshka(bool black, int y, int x)
        {
            this.black = black;
            
            this.y = y;
            this.x = x;
        }

        public override List<Point> CanMove(ref List<Figure> figures)
        {
            List <Point> ans= new List<Point>();
            int popravka = -1;
            if (this.black) 
            {
                popravka *= -1;
            }
            
            if(figures.Where(x => (this.y - 1 * popravka == x.y) && (this.x  == x.x )).Count() == 0) 
            {
                ans.Add(new Point(this.x,this.y-1 * popravka, false,false));
                if(figures.Where(x => (this.y - 2 * popravka == x.y) && (this.x == x.x)).Count() == 0 && doublehod==false)
                {
                    ans.Add(new Point(this.x, this.y-2 * popravka, false, false));
                }
            }

            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
            return ans;
        }
        public override List<Point> CanEat(ref List<Figure> figures)
        {
            List<Point> ans = new List<Point>();

            int popravka = -1;
            if (this.black)
            {
                popravka *= -1;
            }
            List<Figure> ShList = figures.Where(x => (this.y - 1 * popravka == x.y) && (this.x + 1 == x.x || this.x - 1 == x.x) && this.black != x.black).ToList();
            foreach (Figure item in ShList)
            {
                ans.Add(new Point(item.x, item.y, true, true));
            }
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
            return ans; 
        }

    }
}
