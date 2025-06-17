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
    public partial class FrmBresenham : Form
    {
        private PixelDrawer drawer;
        private AlgoritmoBresenham bresenham;
        public FrmBresenham()
        {
            InitializeComponent();
            drawer = new PixelDrawer(picCanvas);
            bresenham = new AlgoritmoBresenham(drawer);
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(txtX1.Text);
            int y1 = int.Parse(txtY1.Text);
            int x2 = int.Parse(txtX2.Text);
            int y2 = int.Parse(txtY2.Text);

            drawer.Delay = trkVelocidad.Value;
            drawer.Limpiar();

            await bresenham.DibujarLineaBresenham(x1, y1, x2, y2);

            lstPixeles.Items.Clear();
            foreach (var p in drawer.ObtenerPixelesEncendidos())
            {
                lstPixeles.Items.Add($"({p.X}, {p.Y})");
            }
        }
    }
}
