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

namespace Path
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            
            path.AddLine(100, 100, 70, 120);
            path.AddLine(70, 120, 100, 140);
            path.AddLine(100, 140, 130, 120);
            path.AddLine(130, 120, 100, 100);
            path.CloseFigure();
            SolidBrush brush = new SolidBrush(Color.Red);
            e.Graphics.FillPath(brush, path);

        }
        public void Path3(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            // Add an open figure.
            path.AddArc(0, 0, 150, 120, 30, 120);

            // Add an intrinsically closed figure.
            path.AddEllipse(50, 50, 50, 100);

            Pen pen = new Pen(Color.FromArgb(128, 0, 0, 255), 5);
            SolidBrush brush = new SolidBrush(Color.Red);

            // The fill mode is FillMode.Alternate by default.
            e.Graphics.FillPath(brush, path);
            e.Graphics.DrawPath(pen, path);
        }
        public void Path1(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(20, 100, 50, 50, 0, 180); // позиция х и у затем ширина и высота 
            e.Graphics.DrawPath(new Pen(Color.FromArgb(128, 255, 0, 0), 4), path);
        }
        public void Path2(PaintEventArgs e)
        {
            // Create an array of points for the curve in the second figure.
            Point[] points = {
   new Point(40, 60),
   new Point(50, 70),
   new Point(30, 90)};

            GraphicsPath path = new GraphicsPath();

            path.StartFigure(); // Start the first figure.
            path.AddArc(175, 50, 50, 50, 0, -180);
            path.AddLine(100, 0, 250, 20);
            // First figure is not closed.
/*
            path.StartFigure(); // Start the second figure.
            path.AddLine(50, 20, 5, 90);
            path.AddCurve(points, 3);
            path.AddLine(50, 150, 150, 180); */
            path.CloseFigure(); // Second figure is closed.

            e.Graphics.DrawPath(new Pen(Color.FromArgb(255, 255, 0, 0), 2), path);
        }
    }
}
