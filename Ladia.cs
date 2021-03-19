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
            
            this.y = y;
            this.x = x;
        }

        public override List<Point> CanMove(ref List<Figure> figures) 
        {
            List<Point> ans = new List<Point>();
            for (int i = this.x+1; i <8 ; i++)
            {
                if (!figures.Exists(x => x.x ==  i && x.y==this.y))
                {
                    ans.Add(new Point(i,this.y,false,false));
                   
                }
                else { break; }
            }

            for (int i = this.x-1; i > -1; i--)
            {
                if (!figures.Exists(x => x.x == i && x.y == this.y))
                {
                    ans.Add(new Point(i, this.y, false, false));

                }
                else { break; }
            }

            for (int i = this.y+1; i < 8; i++)
            {
                if (!figures.Exists(x => x.x == this.x  && x.y == i))
                {
                    ans.Add(new Point(this.x ,i, false, false));

                }
                else { break; }
            }

            for (int i = this.y-1; i > -1; i--)
            {
                if (!figures.Exists(x => x.x == this.x  && x.y == i))
                {
                    ans.Add(new Point(this.x ,i, false, false));

                }
                else { break; }
            }
           



            return ans;
        }
        public override List<Point> CanEat(ref List<Figure> figures) {
            List<Point> ans = new List<Point>();
            for (int i = this.x + 1; i < 8; i++)
            {
                if (figures.Exists(x => x.x == i && x.y == this.y && this.black != x.black))
                {
                    ans.Add(new Point(i, this.y, false, false));
                    break;
                }
                else if (figures.Exists(x => x.x == i && x.y == this.y 
                )) { break; }
                
            }

            for (int i = this.x - 1; i > -1; i--)
            {
                if (figures.Exists(x => x.x == i && x.y == this.y && this.black != x.black))
                {
                    ans.Add(new Point(i, this.y, false, false));
                    break;
                }
                else if (figures.Exists(x => x.x == i && x.y == this.y)){ break; }


            }

            for (int i = this.y + 1; i < 8; i++)
            {
                if (figures.Exists(x => x.x == this.x && x.y == i && this.black != x.black))
                {
                    ans.Add(new Point(this.x, i, false, false));
                    break;
                }
                else if (figures.Exists(x => x.x == this.x && x.y == i)) { break; }


            }

            for (int i = this.y - 1; i > -1; i--)
            {
                if (figures.Exists(x => x.x == this.x && x.y == i && this.black != x.black))
                {
                    ans.Add(new Point(this.x, i, false, false));
                    break;

                }
                if (figures.Exists(x => x.x == this.x && x.y == i)) { break; }


            }




            return ans;
        }

        
    }
}
