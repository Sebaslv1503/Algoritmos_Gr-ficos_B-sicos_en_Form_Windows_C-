using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficos
{
    public partial class FrmDiscretizacion : Form
    {
        private PixelDrawer drawer;
        private AlgoritmoCirculoBresenham circulo;
        private FloodFill floodFill;

        public FrmDiscretizacion()
        {
            InitializeComponent();
            drawer = new PixelDrawer(picCanvas);
            circulo = new AlgoritmoCirculoBresenham(drawer);
            floodFill = new FloodFill(drawer);

            picCanvas.MouseClick += picCanvas_MouseClick;
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            int xc = int.Parse(txtCentroX.Text);
            int yc = int.Parse(txtCentroY.Text);
            int r = int.Parse(txtRadio.Text);

            drawer.Delay = trkVelocidad.Value;
            drawer.Limpiar();

            await circulo.DibujarCircunferenciaBresenham(xc, yc, r);
        
        }

        

        private async void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 5; // ESCALA
            int y = e.Y / 5;
            await floodFill.RellenarAsync(x, y);
        }
    }
}
