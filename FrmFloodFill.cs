using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmFloodFill : Form
    {
        private ComboBox cmbFiguras;
        private Button btnDibujar;
        private TrackBar trkVelocidad;
        private PictureBox picCanvas;
        private Label lblVelocidad;

        private PixelDrawer drawer;
        private FloodFill floodFill;

        public FrmFloodFill()
        {
            InicializarInterfaz();

            drawer = new PixelDrawer(picCanvas);
            floodFill = new FloodFill(drawer);

            cmbFiguras.Items.AddRange(new string[] { "Rectángulo", "Círculo", "Triángulo" });
            cmbFiguras.SelectedIndex = 0;

            picCanvas.MouseClick += picCanvas_MouseClick;
            btnDibujar.Click += btnDibujar_Click;
        }

        private void InicializarInterfaz()
        {
            this.Text = "Flood Fill - Relleno por Inundación";
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
                    FigurasPredefinidas.DibujarRectangulo(picCanvas);
                    break;
                case "Círculo":
                    FigurasPredefinidas.DibujarCirculo(picCanvas);
                    break;
                case "Triángulo":
                    FigurasPredefinidas.DibujarTriangulo(picCanvas);
                    break;
            }

        }

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            drawer.Delay = trkVelocidad.Value;
            await floodFill.RellenarAsync(x, y);
        }
    }
}
