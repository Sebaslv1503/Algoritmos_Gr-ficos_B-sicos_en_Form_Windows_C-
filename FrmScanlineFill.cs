using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmScanlineFill : Form
    {
        private ComboBox cmbFiguras;
        private Button btnDibujar;
        private TrackBar trkVelocidad;
        private PictureBox picCanvas;
        private Label lblVelocidad;

        private PixelDrawer drawer;
        private ScanlineFill scanline;
        private Point[] verticesActuales;

        public FrmScanlineFill()
        {
            InicializarInterfaz();

            drawer = new PixelDrawer(picCanvas);
            scanline = new ScanlineFill(drawer);

            cmbFiguras.Items.AddRange(new string[] { "Rectángulo", "Triángulo", "Pentágono" });
            cmbFiguras.SelectedIndex = 0;

            picCanvas.MouseClick += picCanvas_MouseClick;
            btnDibujar.Click += btnDibujar_Click;
        }

        private void InicializarInterfaz()
        {
            this.Text = "Scanline Fill - Relleno por Barrido";
            this.Size = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            cmbFiguras = new ComboBox
            {
                Location = new Point(20, 20),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            btnDibujar = new Button
            {
                Text = "Dibujar figura",
                Location = new Point(200, 18),
                Width = 120
            };

            lblVelocidad = new Label
            {
                Text = "Velocidad:",
                Location = new Point(350, 22)
            };

            trkVelocidad = new TrackBar
            {
                Location = new Point(420, 15),
                Width = 140,
                Minimum = 0,
                Maximum = 100,
                Value = 20,
                TickFrequency = 10
            };

            picCanvas = new PictureBox
            {
                Location = new Point(20, 60),
                Size = new Size(520, 380),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            this.Controls.Add(cmbFiguras);
            this.Controls.Add(btnDibujar);
            this.Controls.Add(lblVelocidad);
            this.Controls.Add(trkVelocidad);
            this.Controls.Add(picCanvas);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            drawer.Limpiar();
            string figura = cmbFiguras.SelectedItem.ToString();

            switch (figura)
            {
                case "Rectángulo":
                    verticesActuales = new Point[]
                    {
                        new Point(100, 100),
                        new Point(300, 100),
                        new Point(300, 250),
                        new Point(100, 250)
                    };
                    break;

                case "Triángulo":
                    verticesActuales = new Point[]
                    {
                        new Point(150, 100),
                        new Point(250, 250),
                        new Point(50, 250)
                    };
                    break;

                case "Pentágono":
                    verticesActuales = CalcularPoligonoRegular(5, 150, 170, 80);
                    break;
            }

            using (Graphics g = picCanvas.CreateGraphics())
            {
                g.DrawPolygon(Pens.Black, verticesActuales);
            }
        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (verticesActuales == null) return;

            drawer.Delay = trkVelocidad.Value;
            await scanline.RellenarPoligonoAsync(verticesActuales);
        }

        // Método auxiliar para calcular los puntos de un polígono regular centrado
        private Point[] CalcularPoligonoRegular(int lados, int centroX, int centroY, int radio)
        {
            Point[] puntos = new Point[lados];
            for (int i = 0; i < lados; i++)
            {
                double angulo = 2 * Math.PI * i / lados - Math.PI / 2;
                int x = centroX + (int)(radio * Math.Cos(angulo));
                int y = centroY + (int)(radio * Math.Sin(angulo));
                puntos[i] = new Point(x, y);
            }
            return puntos;
        }
    }
}
