using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMate
{
    class Table
    {

        public List<Figure> WhiteFigures = new List<Figure>();
        public List<Figure> BlackFigures = new List<Figure>();
        public Cell[,] field;
        public Table()
        {
            this.WhiteFigures = new List<Figure>();
            this.BlackFigures = new List<Figure>();
            field = new Cell[8,8];

            this.GenerateFild();
        }
       private void GenerateFild()
        {
            GenField();
            GenFig(false);
            GenFig(true);
            GenPesk();
            RescanFigures();
        }


        private void GenField() 
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.field[i, j] = new Cell(i, j,null);
                }
            }
        }

        private void GenPesk() 
        {
            
            
            for (int i = 0; i < 8; i++)
            {
              
                field[6, i].fig = new Peshka(false, 6, i);

            }

            for (int i = 0; i < 8; i++)
            {




                field[1, i].fig = new Peshka(true, 1, i);
            }
            field[4, 1].fig = new Korol(true, 4, 1);
            BlackFigures.Add(field[4, 1].fig);
        }

        private void GenFig(bool black) 
        {
            int i = 0;
            var b = WhiteFigures;
            if (!black) 
            {
                b = BlackFigures;
                i = 7;
            }

            int y = 0;
           
            field[i, y].fig = new   Ladia(black,i, y);
            field[i, 7 - y].fig = new Ladia(black, i, 7-y++);
            field[i, y].fig = new Kon(black, i, y);
            field[i, 7 - y].fig = new Kon(black, i,7 - y++);
            field[i, y].fig = new Slon(black, i,y);
            field[i, 7 - y].fig = (new Slon(black, i,7 - y++));
            field[i, y].fig = (new Ferz(black, i, y));
            field[i, 7 - y].fig = new Korol(black, i ,7 - y++);

        }

        private void RescanFigures() 
        {
            WhiteFigures.Clear();
            BlackFigures.Clear();
            foreach (Cell cell in field)
            {
                if (cell.fig != null) 
                {
                    if (cell.fig.black) 
                    {
                        BlackFigures.Add(cell.fig);
    
                    }
                    else 
                    {
                        WhiteFigures.Add(cell.fig);
                    }
                }
            }
        }
    }

   
}
