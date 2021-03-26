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

        public override List<Cell> CanMove(ref Cell[,] table) 
        {
            List<Cell> ans = new List<Cell>();
            for (int i = this.x+1; i <8 ; i++)
            {
                if (table[this.y,i].fig==null)
                {
                    ans.Add(table[this.y, i]);
                   
                }
                else 
                {
                    break; 
                }
            }

            for (int i = this.x-1; i > -1; i--)
            {
                if (table[this.y, i].fig == null)
                {
                    ans.Add(table[this.y, i]);

                }
                else { break; }
            }

            for (int i = this.y+1; i < 8; i++)
            {
                if( table[i, this.x].fig == null)
                {
                    ans.Add(table[i, this.x]);

                }
                else { break; }
            }

            for (int i = this.y-1; i > -1; i--)
            {
                if (table[i, this.x].fig == null)
                {
                    ans.Add(table[i, this.x]);

                }
                else { break; }
            }
           



            return ans;
        }
        public override List<Cell> CanEat(ref Cell[,] table) {
            List<Cell> ans = new List<Cell>();
            for (int i = this.x + 1; i < 8; i++)
            {
                if (table[this.y, i].fig != null && this.black!= table[this.y, i].fig.black)
                {
                    ans.Add(table[this.y, i]);
                    break;                  
                }
                else if (table[this.y, i].fig == null)
                {
                    break;
                }
                
            }

            for (int i = this.x - 1; i > -1; i--)
            {
                if (table[this.y, i].fig != null && this.black != table[this.y, i].fig.black)
                {
                    ans.Add(table[this.y, i]);
                    break;
                }
                else if (table[this.y, i].fig == null)
                {
                    break;
                }


            }

            for (int i = this.y + 1; i < 8; i++)
            {
                if (table[i,this.x ].fig != null && this.black != table[i, this.x].fig.black)
                {
                    ans.Add(table[i, this.x]);
                    break;
                }
                else if (table[i, this.x].fig == null)
                {
                    break;
                }


            }

            for (int i = this.y - 1; i > -1; i--)
            {
                if (table[i, this.x].fig != null && this.black != table[i, this.x].fig.black)
                {
                    ans.Add(table[i, this.x]);
                    break;
                }
                else if (table[i, this.x].fig == null)
                {
                    break;
                }
            }



                return ans;
        }

        
    }
}
