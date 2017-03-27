using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphicsOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                Shape s = new Shape(10 + i * 30, 10 * i, 40, 40);
                e.Graphics.FillPath(new Pen(Color.Red).Brush, s.gp);
            }
        }
    }
    

}
