using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Table
    {

        public List<Figure> figures = new List<Figure>();

        public Table()
        {
            this.figures = new List<Figure>(32);
            

            this.GenerateFild();
        }
       private void GenerateFild()
        {
            GenFig(false);
            GenFig(true);
            GenPesk();
        }

        private void GenPesk() 
        {
            
            
            for (int i = 0; i < 8; i++)
            {
                figures.Add( new Peshka(false,1,i));
            }

            for (int i = 0; i < 8; i++)
            {
                figures.Add(new Peshka(true,  6, i));
            }
            figures.Add(new Ladia(false, 5, 1));
        }

        private void GenFig(bool black) 
        {
            int i = 0;
            if (black) { i = 7; }

            int y = 0;
            figures.Add(new   Ladia(black,i, y));
            figures.Add(new Ladia(black, i, 7-y++));
            figures.Add(new Kon(black, i, y));
            figures.Add(new Kon(black, i,7 - y++));
            figures.Add(new Slon(black, i,y));
            figures.Add(new Slon(black, i,7 - y++));
            figures.Add(new Ferz(black, i, y));
            figures.Add(new Korol(black, i ,7 - y++));

        }
    }

   
}
