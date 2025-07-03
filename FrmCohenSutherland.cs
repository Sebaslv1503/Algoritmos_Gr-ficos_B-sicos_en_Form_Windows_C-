using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmCohenSutherland : Form
    {

        Rectangle clippingRect;
        int cellWidth, cellHeight;
        List<(Point, Point)> lines = new List<(Point, Point)>();
        List<(Point, Point)> clippedLines = new List<(Point, Point)>();
        bool isDrawing = false;
        Point startPoint, currentPoint;

        public FrmCohenSutherland()
        {
            InicializarInterfaz();

            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            picCanvas.Paint += picCanvas_Paint;

            btnRecortar.Click += btnRecortar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void InicializarInterfaz()
        {
            this.Text = "Algoritmo de Recorte - Cohen Sutherland";
            this.Size = new Size(650, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnRecortar = new Button
            {
                Text = "Recortar",
                Location = new Point(20, 15),
                Size = new Size(80, 30)
            };

            btnLimpiar = new Button
            {
                Text = "Limpiar",
                Location = new Point(120, 15),
                Size = new Size(80, 30)
            };

            picCanvas = new PictureBox
            {
                Location = new Point(20, 60),
                Size = new Size(580, 380),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            this.Controls.Add(btnRecortar);
            this.Controls.Add(btnLimpiar);
            this.Controls.Add(picCanvas);
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            currentPoint = e.Location;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                Point endPoint = e.Location;
                lines.Add((startPoint, endPoint));
                picCanvas.Invalidate();
            }
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            clippedLines.Clear();

            foreach (var line in lines)
            {
                if (CohenSutherland.ClipLine(line.Item1, line.Item2, clippingRect, out Point p1, out Point p2))
                {
                    clippedLines.Add((p1, p2));
                }
            }

            picCanvas.Invalidate();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lines.Clear();
            clippedLines.Clear();
            isDrawing = false;
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            cellWidth = picCanvas.Width / 3;
            cellHeight = picCanvas.Height / 3;

            // Dibujar cuadrícula 3x3
            for (int i = 1; i < 3; i++)
            {
                g.DrawLine(Pens.LightGray, 0, i * cellHeight, picCanvas.Width, i * cellHeight);
                g.DrawLine(Pens.LightGray, i * cellWidth, 0, i * cellWidth, picCanvas.Height);
            }

            // Rectángulo de recorte (centro)
            clippingRect = new Rectangle(cellWidth, cellHeight, cellWidth, cellHeight);
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(pen, clippingRect);
            }

            // Dibujar líneas
            using (Pen originalPen = new Pen(Color.Gray, 2))
            using (Pen clippedPen = new Pen(Color.Green, 3))
            using (Pen currentPen = new Pen(Color.Blue, 2))
            {
                foreach (var line in lines)
                    g.DrawLine(originalPen, line.Item1, line.Item2);

                foreach (var clipped in clippedLines)
                    g.DrawLine(clippedPen, clipped.Item1, clipped.Item2);

                if (isDrawing)
                    g.DrawLine(currentPen, startPoint, currentPoint);
            }
        }
    }
}
