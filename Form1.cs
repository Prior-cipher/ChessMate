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
        public Form1()
        {
            InitializeComponent();
            MarkColoir();
            this.Size =new  Size(700,700);
            Table table = new Table();
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
               
            }
            for (int i = 1; i < tableLayoutPanel1.RowCount-1; i += 2)
            {
                int z = 2;
                if (i % 2 ==0)
                { 
                    z = 1;
                }
                for (; z < tableLayoutPanel1.ColumnCount-1; z += 2)
                {
                    tableLayoutPanel1.GetControlFromPosition(z, i).BackColor = Color.Black;
                    tableLayoutPanel1.GetControlFromPosition(z, i).ForeColor = Color.White;
                }
                i -= 1;
                
            }


        }
       private void Otrisovka(Table table) 
        {
            foreach (Figure item in table.figures)
            {
                tableLayoutPanel1.GetControlFromPosition(item.x + 1, 7-item.y + 1).Text=item.figura.ToString()+"\\n"+item.black;
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
