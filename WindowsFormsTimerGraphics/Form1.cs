using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimerGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float x = 30, y = 30;
        float w = 0, h = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Blue), x, y, w, h);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            w += (float)2.5;
            h += (float)2.5;
            Refresh();
        }
    }
}
