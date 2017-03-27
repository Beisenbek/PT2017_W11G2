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

namespace WindowsFormsGraphicsRotations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gp.AddLine(200, 60, 200, 100);
        }

        GraphicsPath gp = new GraphicsPath();
        private void button1_Click(object sender, EventArgs e)
        {
            Matrix m = new Matrix();
            m.Rotate(45);
            gp.Transform(m);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(Color.Red), gp);
        }
    }
}
