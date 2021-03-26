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

        public override List<Cell> CanMove(ref Cell[,] table)
        {
            List <Cell> ans = new List<Cell>();

            if (this.black)
            {
                if (this.y + 1 < 8 && table[this.y + 1, this.x].fig == null)
                {
                    ans.Add(table[this.y + 1, this.x]);
                }
                else { return ans; }
            }
            else
            {
                if (this.y - 1 > -1 && table[this.y - 1, this.x].fig == null)
                {
                    ans.Add(table[this.y - 1, this.x]);
                }
                else { return ans; }
            }
            if (!doublehod && (this.y == 1 || this.y == 6)) 
            {
                if (this.black) 
                {
                    if (this.y + 2 < 8 && table[this.y + 2, this.x].fig == null) 
                    {
                        ans.Add(table[this.y + 2, this.x]);
                    }

                    
                }
                else 
                {
                    if (this.y - 2 >-1 && table[this.y - 2, this.x].fig == null)
                    {
                        ans.Add(table[this.y - 2, this.x]);
                    }
                   
                }
            }
            


          
            return ans;
        }
        public override List<Cell> CanEat(ref Cell[,] table)
        {
            List<Cell> ans = new List<Cell>();
            if (this.black)
                {
                    if (this.y +1 < 8 && this.x+1<8 && table[this.y  +1, this.x+1].fig != null)
                    {
                        ans.Add(table[this.y + 1, this.x + 1]);
                    }

                         if (this.y + 1 < 8 && this.x -1>-1 && table[this.y + 1, this.x - 1].fig != null)
                        {
                            ans.Add(table[this.y + 1, this.x - 1]);
                        }
            }
                else
                {
                    if (this.y - 11 > -1 && this.x + 1 < 8 && table[this.y - 1, this.x + 1].fig != null)
                {
                    ans.Add(table[this.y - 1, this.x + 1]);
                }

                if (this.y - 1 > -1 && this.x - 1 > -1 && table[this.y - 1, this.x - 1].fig != null)
                {
                    ans.Add(table[this.y - 1, this.x - 1]);
                }

            }
            

          



            return ans;
        }

    }
}
