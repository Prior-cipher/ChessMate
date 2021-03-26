using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMate
{
    public partial class Form1 : Form
    {
        Table table;
        public Form1()
        {
            InitializeComponent();
            MarkColoir();
            this.Size =new  Size(700,700);
            table = new Table();
            Otrisovka(table);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MarkColoir() 
        {
            for (int i = 0; i < 100; i++)
            {
                tableLayoutPanel1.Controls.Add(new Label());
            }
            int j = 0;

            foreach (Label item in tableLayoutPanel1.Controls.OfType<Label>()  )
            {
                item.Name = (j++).ToString();
                item.Text = item.Name;
                item.Visible = true;
                item.Dock = DockStyle.Fill;
                item.Click += On_Click;
               
            }
            


        }

        private void On_Click(object sender, EventArgs e)
        {
            Otrisovka(table);
            Label label = sender as Label;
            var a=tableLayoutPanel1.GetPositionFromControl(label);
            int x = a.Column-1;
            int y = a.Row-1;
            Console.WriteLine(y + " " + x);
            if (table.field[y, x].fig != null) 
            {
                 var c = table.field[y, x].fig;
                //item.CanMove(ref table.figures);
                foreach (Cell cell in c.CanMove(ref table.field))
                {
                    tableLayoutPanel1.GetControlFromPosition(cell.x + 1, cell.y+1).BackColor = Color.Blue;
                }
                Console.WriteLine();

                foreach (Cell cell in c.CanEat(ref table.field))
                {
                    tableLayoutPanel1.GetControlFromPosition(cell.x + 1, cell.y + 1).BackColor = Color.Red;
                }
            }

                
                
            
            


           
        }

        private void Otrisovka(Table table) 
        {
            


            for (int i = 1; i < tableLayoutPanel1.RowCount - 1; i ++)
            {
              
                for (int z = 1; z < tableLayoutPanel1.ColumnCount - 1; z ++)
                {

                    if (i % 2 == 0)
                    {
                        if (z % 2 == 1)
                        {
                            tableLayoutPanel1.GetControlFromPosition(z, i).BackColor = Color.Black;
                            tableLayoutPanel1.GetControlFromPosition(z, i).ForeColor = Color.White;
                        }
                        else 
                        {
                            tableLayoutPanel1.GetControlFromPosition(z, i).BackColor = Color.White;
                            tableLayoutPanel1.GetControlFromPosition(z, i).ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (z % 2 == 1)
                        {
                            tableLayoutPanel1.GetControlFromPosition(z, i).BackColor = Color.White;
                            tableLayoutPanel1.GetControlFromPosition(z, i).ForeColor = Color.Black;
                        }
                        else
                        {
                            tableLayoutPanel1.GetControlFromPosition(z, i).BackColor = Color.Black;
                            tableLayoutPanel1.GetControlFromPosition(z, i).ForeColor = Color.White;
                        }
                    }
                   
                }
                

            }

            foreach (Cell cell in table.field)
            {
                if (cell.fig != null) 
                {
                    tableLayoutPanel1.GetControlFromPosition(cell.x + 1,  cell.y+1 ).Text = cell.fig.GetType().Name + "\n" + cell.fig.black;
                }
                
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
