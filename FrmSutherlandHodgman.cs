using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmSutherlandHodgman : Form
    {
        private PictureBox picCanvas;
        private Button btnRecortar;
        private Button btnLimpiar;

        private List<Point> polygon = new List<Point>();
        private List<Point> clippedPolygon = new List<Point>();
        private Rectangle clipRect;
        private int cellW, cellH;

        public FrmSutherlandHodgman()
        {
            InicializarInterfaz();

            picCanvas.MouseClick += picCanvas_MouseClick;
            picCanvas.Paint += picCanvas_Paint;
            btnRecortar.Click += btnRecortar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void InicializarInterfaz()
        {
            this.Text = "Sutherland-Hodgman - Recorte de Polígonos";
            this.Size = new Size(650, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

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

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            polygon.Add(e.Location);
            if (polygon.Count >= 3)
            {
                clippedPolygon.Clear(); // Se limpia hasta que se presione recortar
            }
            picCanvas.Invalidate();
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            if (polygon.Count >= 3)
            {
                clippedPolygon = SutherlandHodgman.ClipPolygon(polygon, clipRect);
                picCanvas.Invalidate();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            polygon.Clear();
            clippedPolygon.Clear();
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            cellW = picCanvas.Width / 3;
            cellH = picCanvas.Height / 3;
            clipRect = new Rectangle(cellW, cellH, cellW, cellH);

            // Dibujar cuadrícula 3x3
            for (int i = 1; i < 3; i++)
            {
                g.DrawLine(Pens.LightGray, 0, i * cellH, picCanvas.Width, i * cellH);
                g.DrawLine(Pens.LightGray, i * cellW, 0, i * cellW, picCanvas.Height);
            }

            // Rectángulo de recorte (centro)
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawRectangle(pen, clipRect);
            }

            // Polígono original
            if (polygon.Count >= 2)
            {
                using (Pen thickRedPen = new Pen(Color.DarkRed, 2))
                {
                    g.DrawPolygon(thickRedPen, polygon.ToArray());
                }
            }

            // Polígono recortado
            if (clippedPolygon.Count >= 3)
            {
                using (Pen thickGreenPen = new Pen(Color.Green, 3))
                {
                    g.DrawPolygon(thickGreenPen, clippedPolygon.ToArray());
                }
            }

            // Vértices del polígono original (azul)
            foreach (Point p in polygon)
            {
                g.FillEllipse(Brushes.Blue, p.X - 4, p.Y - 4, 8, 8);
            }

            // Vértices del polígono recortado (verde oscuro)
            foreach (Point p in clippedPolygon)
            {
                g.FillEllipse(Brushes.DarkGreen, p.X - 4, p.Y - 4, 8, 8);
            }
        }
    }
}
