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
    public partial class FrmCurvasBezier : Form
    {
        private BezierLines simpleLines;
        public FrmCurvasBezier()
        {
            InitializeComponent();
            // Inicializamos la clase SimpleLines
            simpleLines = new BezierLines(0, picCanvas.Width, 0, 10);



            // Evento para redibujar cuando mueves el TrackBar
            trackBar.Scroll += (s, e) => picCanvas.Invalidate();

            // Evento Paint del PictureBox
            picCanvas.Paint += picCanvas_Paint;
        }
        private void FrmSimpleLines_Load(object sender, EventArgs e)
        {

        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            simpleLines.Draw(e.Graphics, trackBar.Value);
        }
    }
}
