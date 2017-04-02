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

namespace PaintEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /* Bitmap bitmap = new Bitmap("Texture1.jpg");
             TextureBrush tBrush = new TextureBrush(bitmap);
             Pen texturedPen = new Pen(tBrush, 30);

             e.Graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
             e.Graphics.DrawEllipse(texturedPen, 100, 20, 200, 100);*/

            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 20, 175, 300, 175);
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            Pen greenPen = new Pen(Color.FromArgb(255, 0, 255, 0), 10);


            // Draw the rectangle with the wide green pen.
            e.Graphics.DrawRectangle(greenPen, 10, 100, 50, 50);

            // Draw the rectangle with the thin black pen.
            e.Graphics.DrawRectangle(blackPen, 10, 100, 50, 50);



            GraphicsPath path = new GraphicsPath();
            Pen penJoin = new Pen(Color.FromArgb(255, 0, 0, 255), 8);

            path.StartFigure();
            path.AddLine(new Point(50, 200), new Point(100, 200));
            path.AddLine(new Point(100, 200), new Point(100, 250));
            path.AddLine(new Point(100, 250), new Point(50, 250));
            penJoin.LineJoin = LineJoin.Bevel;
            e.Graphics.DrawPath(penJoin, path);
            /*DashLines(e);*/ //деление линии
            /*HatchBrush(e);*/ //заполнение фигруры+ линииии
            /*LineaGradient(e);*/ //линенйный градиент плавный переход цвета https://msdn.microsoft.com/en-us/library/0sdy66e6(v=vs.110).aspx
        }
        private void LineaGradient(PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            new Point(0, 10),
            new Point(200, 10),
            Color.FromArgb(255, 255, 0, 0),   // Opaque red
            Color.FromArgb(255, 0, 0, 255));  // Opaque blue

            Pen pen = new Pen(linGrBrush);

            e.Graphics.DrawLine(pen, 0, 10, 200, 10);
            e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
            e.Graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
        }
        private void HatchBrush(PaintEventArgs e) //заполнение фигруры+ линииии
        {
            HatchBrush hBrush = new HatchBrush(
          HatchStyle.Horizontal,
          Color.Red,
          Color.FromArgb(255, 128, 255, 255));
            e.Graphics.FillEllipse(hBrush, 100, 50, 100, 60);
        }


        private void DashLines(PaintEventArgs e)
        {
            float[] dashValues = { 10, 21, 15, 4 };//длина первого, длина пустоты после первого, длина вотрого, длина пустоты после второго и так продолжается
            Pen blackPen = new Pen(Color.Black, 5);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawLine(blackPen, new Point(5, 5), new Point(405, 5));
        }
        private void DrawEllipse()
        {
            Pen myPen = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(0, 0, 200, 300));
        }

        private void DrawRectangle()
        {
            Pen myPen = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 0, 200, 300));
        }
        public void DrawString()
        {
            Graphics formGraphics = this.CreateGraphics();
            string drawString = "Sample Text";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            StringFormat drawFormat = new StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }
        //как написать веритакальный текст
        public void DrawVerticalString()
        {
            Graphics formGraphics = this.CreateGraphics();
            string drawString = "Sample Text";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);

        }
    }
}
