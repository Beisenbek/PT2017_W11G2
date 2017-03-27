﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        int k = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            k++;
            label1.Text = k.ToString();
            Pen pen = new Pen(Color.Red);
            SolidBrush b = new SolidBrush(Color.Green);
            e.Graphics.DrawLine(pen, 0, 0, 100, 100);
            e.Graphics.DrawRectangle(pen, 0, 0, 200, 100);
            e.Graphics.FillEllipse(b, 10, 10, 30, 50);
            e.Graphics.FillEllipse(pen.Brush, 100, 10, 30, 50);
        }
    }
}
