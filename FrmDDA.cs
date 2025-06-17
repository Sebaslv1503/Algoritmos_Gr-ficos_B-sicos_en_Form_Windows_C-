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
    public partial class FrmDDA : Form
    {
        private PixelDrawer drawer;
        private AlgoritmoDDA dda;
        public FrmDDA()
        {
            InitializeComponent();
            drawer = new PixelDrawer(picCanvas);
            dda = new AlgoritmoDDA(drawer);
        }

        private async void btnDibujar_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(txtX1.Text);
            int y1 = int.Parse(txtY1.Text);
            int x2 = int.Parse(txtX2.Text);
            int y2 = int.Parse(txtX2.Text);

            
            drawer.Delay = trkVelocidad.Value;

            drawer.Limpiar();
            await dda.DibujarLineaDDA(x1, y1, x2, y2);

            lstPixeles.Items.Clear();
            foreach (var p in drawer.ObtenerPixelesEncendidos())
            {
                lstPixeles.Items.Add($"({p.X}, {p.Y})");
            }
        }

    }
}
