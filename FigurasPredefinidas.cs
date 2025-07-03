using System.Drawing;
using System.Windows.Forms;

public static class FigurasPredefinidas
{
    public static void DibujarRectangulo(PictureBox picCanvas)
    {
        using (Graphics g = Graphics.FromImage(picCanvas.Image))
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, 100, 80, 200, 150);
        }
        picCanvas.Refresh();
    }

    public static void DibujarCirculo(PictureBox picCanvas)
    {
        using (Graphics g = Graphics.FromImage(picCanvas.Image))
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawEllipse(pen, 130, 100, 150, 150);
        }
        picCanvas.Refresh();
    }

    public static void DibujarTriangulo(PictureBox picCanvas)
    {
        using (Graphics g = Graphics.FromImage(picCanvas.Image))
        {
            Pen pen = new Pen(Color.Black, 1);
            Point[] puntos = new Point[]
            {
                new Point(160, 100),
                new Point(100, 250),
                new Point(280, 250)
            };
            g.DrawPolygon(pen, puntos);
        }
        picCanvas.Refresh();
    }
}
