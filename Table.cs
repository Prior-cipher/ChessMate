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
                figures.Add( new Figure(false,FigType.peshka,1,i));
            }

            for (int i = 0; i < 8; i++)
            {
                figures.Add(new Figure(true, FigType.peshka, 6, i));
            }
        }

        private void GenFig(bool black) 
        {
            int i = 0;
            if (black) { i = 7; }

            int y = 0;
            figures.Add(new   Ladia(true,i, y));
            figures.Add(new Ladia(true,i, 7-y++));
            figures.Add(new Figure(true, FigType.kon,i, y));
            figures.Add(new Figure(true, FigType.kon, i,7 - y++));
            figures.Add(new Figure(true, FigType.slon, i,y));
            figures.Add(new Figure(true, FigType.slon, i,7 - y++));
            figures.Add(new Figure(true, FigType.ferz,i, y));
            figures.Add(new Figure(true, FigType.korol,i ,7 - y++));

        }
    }

   
}
