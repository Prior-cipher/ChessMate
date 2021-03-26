using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Slon:Figure
    {
        public Slon(bool black, int y, int x)
        {
            this.black = black;
           
            this.y = y;
            this.x = x;
        }
        public override List<Cell> CanMove(ref Cell[,] table) 
        {
            List<Cell> ans = new List<Cell>();
            for (int i = 1; this.x+i <8 && this.y + i < 8; i++)
            {
                if (table[this.y+i,this.x+i].fig==null)
                {
                    ans.Add(table[this.y + i, this.x + i]);
                   
                }
                else 
                {
                    break; 
                }
            }

            for (int i = 1; this.x + i < 8 && this.y - i > -1; i++)
            {
                if (table[this.y - i, this.x + i].fig == null)
                {
                    ans.Add(table[this.y - i, this.x + i]);

                }
                else
                {
                    break;
                }
            }

            for (int i = 1; this.x - i >-1 && this.y + i < 8; i++)
            {
                if (table[this.y + i, this.x - i].fig == null)
                {
                    ans.Add(table[this.y + i, this.x - i]);

                }
                else
                {
                    break;
                }
            }

            for (int i = 1; this.x - i > -1 && this.y - i > -1; i++)
            {
                if (table[this.y - i, this.x - i].fig == null)
                {
                    ans.Add(table[this.y - i, this.x - i]);

                }
                else
                {
                    break;
                }
            }




            return ans;
        }
        public override List<Cell> CanEat(ref Cell[,] table) {
            List<Cell> ans = new List<Cell>();
            for (int i = 1; this.x + i < 8 && this.y + i < 8; i++)
            {
                if (table[this.y + i, this.x + i].fig != null)
                {
                    if (table[this.y + i, this.x + i].fig.black != this.black)
                    {
                        ans.Add(table[this.y + i, this.x + i]);
                    }
                    
                    break;
                }
               
            }

            for (int i = 1; this.x + i < 8 && this.y - i >-1; i++)
            {
                if (table[this.y - i, this.x + i].fig != null)
                {
                    if (table[this.y - i, this.x + i].fig.black != this.black)
                    {
                        ans.Add(table[this.y - i, this.x + i]);
                    }

                    break;
                }

            }

            for (int i = 1; this.x - i >-1 && this.y - i >-1; i++)
            {
                if (table[this.y - i, this.x - i].fig != null)
                {
                    if (table[this.y - i, this.x - i].fig.black != this.black)
                    {
                        ans.Add(table[this.y - i, this.x - i]);
                    }

                    break;
                }

            }

            for (int i = 1; this.x - i >-1 && this.y + i < 8; i++)
            {
                if (table[this.y + i, this.x - i].fig != null)
                {
                    if (table[this.y + i, this.x - i].fig.black != this.black)
                    {
                        ans.Add(table[this.y + i, this.x - i]);
                    }

                    break;
                }

            }




            return ans;
        }
    }
}
