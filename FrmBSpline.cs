using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmBSpline : Form
    {
        private List<PointF> puntosControl = new List<PointF>();

        public FrmBSpline()
        {
            InitializeComponent();
            this.Text = "Dibujo Interactivo de B-Spline";

            // Eventos del PictureBox
            picCanvas.MouseClick += PicCanvas_MouseClick;
            picCanvas.Paint += PicCanvas_Paint;

            // Doble buffer para evitar parpadeo
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            puntosControl.Add(e.Location);
            picCanvas.Invalidate(); // Forzar repintado
        }

        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            // Dibuja puntos de control
            foreach (var p in puntosControl)
            {
                g.FillEllipse(Brushes.Red, p.X - 4, p.Y - 4, 8, 8);
            }

            // Dibuja líneas de control
            if (puntosControl.Count >= 2)
            {
                using (Pen penControl = new Pen(Color.Gray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                {
                    g.DrawLines(penControl, puntosControl.ToArray());
                }
            }

            // Dibuja la B-Spline si hay suficientes puntos
            if (puntosControl.Count >= 4)
            {
                B_Spline spline = new B_Spline(puntosControl, grado: 3);
                List<PointF> curva = spline.CalcularBSpline();

                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    for (int i = 0; i < curva.Count - 1; i++)
                    {
                        g.DrawLine(pen, curva[i], curva[i + 1]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntosControl.Clear();
            picCanvas.Invalidate();
        }
    }
}
