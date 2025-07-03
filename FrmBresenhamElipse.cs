using System;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmBresenhamElipse : Form
    {
        private PixelDrawer drawer;
        private AlgoritmoElipseBresenham elipse;

        public FrmBresenhamElipse()
        {
            InitializeComponent();

            // Inicializa el drawer y algoritmo
            drawer = new PixelDrawer(picCanvas);
            elipse = new AlgoritmoElipseBresenham(drawer);
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                int xc = int.Parse(txtCentroX.Text);
                int yc = int.Parse(txtCentroY.Text);
                int rx = int.Parse(txtRadioX.Text);
                int ry = int.Parse(txtRadioY.Text);

                // Control de velocidad
                drawer.Delay = trkVelocidad.Value;

                // Limpia el canvas
                drawer.Limpiar();

                // Dibuja la elipse
                await elipse.DibujarElipseBresenham(xc, yc, rx, ry);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos: " + ex.Message);
            }
        }
    }
}
