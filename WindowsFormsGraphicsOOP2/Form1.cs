using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphicsOOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Shape2 s = new Shape2(10, 10, 50, 50,Color.Green);
            Shape2 s2 = new Shape2(100, 30, 50, 50,Color.Blue);

            s.Draw(e.Graphics);
            s2.Draw(e.Graphics);
        }

        string[] colors = { "blue","cyan","red","pink","purple"};

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, colors.Length);
            Shape2 s = new Shape2(e.X - 25, e.Y - 25, 50, 50,Color.FromName(colors[index]));
            Graphics g = this.CreateGraphics();
            s.Draw(g);
        }
    }
}
