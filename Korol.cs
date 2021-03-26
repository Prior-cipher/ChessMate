using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Korol: Figure
    {
        public Korol(bool black, int y, int x)
        {
            this.black = black;

            this.y = y;
            this.x = x;
        }

        public override List<Cell> CanMove(ref Cell[,] table)
        {
            List<Cell> ans = new List<Cell>();

            int i = this.x + 1;
            if ( i < 8 )
            {
                if (table[this.y, i].fig == null)
                {
                    ans.Add(table[this.y, i]);

                }
                
            }
            i = this.x - 1;
            if ( i > -1)
            {
                if (table[this.y, i].fig == null)
                {
                    ans.Add(table[this.y, i]);

                }
               
            }
            i = this.y + 1;
            if ( i < 8)
            {
                if (table[i, this.x].fig == null)
                {
                    ans.Add(table[i, this.x]);

                }
                
            }
            i = this.y - 1;
            if( i > -1)
            {
                if (table[i, this.x].fig == null)
                {
                    ans.Add(table[i, this.x]);

                }
                
            }
            i = 1;
            if( this.x + i < 8 && this.y + i < 8)
            {
                if (table[this.y + i, this.x + i].fig == null)
                {
                    ans.Add(table[this.y + i, this.x + i]);

                }
                
            }

            if ( this.x + i < 8 && this.y - i > -1)
            {
                if (table[this.y - i, this.x + i].fig == null)
                {
                    ans.Add(table[this.y - i, this.x + i]);

                }
                
            }

            if( this.x - i > -1 && this.y + i < 8)
            {
                if (table[this.y + i, this.x - i].fig == null)
                {
                    ans.Add(table[this.y + i, this.x - i]);

                }
              
            }

           if(this.x - i > -1 && this.y - i > -1)
            {
                if (table[this.y - i, this.x - i].fig == null)
                {
                    ans.Add(table[this.y - i, this.x - i]);

                }
               
            }


            return ans;
        }
        public override List<Cell> CanEat(ref Cell[,] table)
        {
            List<Cell> ans = new List<Cell>();
            int i = this.x + 1;
            if( i < 8)
            {
                if (table[this.y, i].fig != null && this.black != table[this.y, i].fig.black)
                {
                    ans.Add(table[this.y, i]);
                   
                }
               

            }
            i = this.x - 1;
            if( i > -1)
            {
                if (table[this.y, i].fig != null && this.black != table[this.y, i].fig.black)
                {
                    ans.Add(table[this.y, i]);
                    
                }
                

            }
            i = this.y + 1;
            if(  i < 8)
            {
                if (table[i, this.x].fig != null && this.black != table[i, this.x].fig.black)
                {
                    ans.Add(table[i, this.x]);
                    
                }
                


            }
            i = this.y - 1;
            if (i > -1)
            {
                if (table[i, this.x].fig != null && this.black != table[i, this.x].fig.black)
                {
                    ans.Add(table[i, this.x]);

                }
            }
                i = 1;
            if ( this.x + i < 8 && this.y + i < 8)
            {
                if (table[this.y + i, this.x + i].fig != null)
                {
                    if (table[this.y + i, this.x + i].fig.black != this.black)
                    {
                        ans.Add(table[this.y + i, this.x + i]);
                    }

                   
                }

            }

            if (this.x + i < 8 && this.y - i > -1)
            {
                if (table[this.y - i, this.x + i].fig != null)
                {
                    if (table[this.y - i, this.x + i].fig.black != this.black)
                    {
                        ans.Add(table[this.y - i, this.x + i]);
                    }

                    
                }

            }

            if ( this.x - i > -1 && this.y - i > -1)
            {
                if (table[this.y - i, this.x - i].fig != null)
                {
                    if (table[this.y - i, this.x - i].fig.black != this.black)
                    {
                        ans.Add(table[this.y - i, this.x - i]);
                    }

                   
                }

            }

            if ( this.x - i > -1 && this.y + i < 8)
            {
                if (table[this.y + i, this.x - i].fig != null)
                {
                    if (table[this.y + i, this.x - i].fig.black != this.black)
                    {
                        ans.Add(table[this.y + i, this.x - i]);
                    }

                   
                }

            }


            return ans;
        }
    }
}
