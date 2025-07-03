using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

public class PixelDrawer
{
    private Graphics g;
    private List<Point> pixelesEncendidos;
    private PictureBox canvas;
    private Brush pixelBrush = Brushes.Black;
    private const int ESCALA = 1;
    private Bitmap bitmap;

    public int Delay { get; set; } = 20; // Valor por defecto

    public int AnchoCanvas => canvas.Width / ESCALA;
    public int AltoCanvas => canvas.Height / ESCALA;

    public PixelDrawer(PictureBox picCanvas)
    {
        canvas = picCanvas;
        g = canvas.CreateGraphics();
        bitmap = new Bitmap(canvas.Width, canvas.Height);
        canvas.Image = bitmap;

        pixelesEncendidos = new List<Point>();
    }

    public async Task DibujarPixelAnimado(int x, int y)
    {
        g.FillRectangle(pixelBrush, x * ESCALA, y * ESCALA, ESCALA, ESCALA);

        // También pintamos en el bitmap para usarlo en detección
        using (Graphics bmpGraphics = Graphics.FromImage(bitmap))
        {
            bmpGraphics.FillRectangle(pixelBrush, x * ESCALA, y * ESCALA, ESCALA, ESCALA);
        }

        pixelesEncendidos.Add(new Point(x, y));
        await Task.Delay(Delay);
    }

    public List<Point> ObtenerPixelesEncendidos()
    {
        return pixelesEncendidos;
    }

    public void Limpiar()
    {
        g.Clear(Color.White);
        using (Graphics bmpGraphics = Graphics.FromImage(bitmap))
        {
            bmpGraphics.Clear(Color.White);
        }
        pixelesEncendidos.Clear();
        canvas.Refresh();
    }

    public bool EstaPintado(int x, int y)
    {
        int px = x * ESCALA + ESCALA / 2;
        int py = y * ESCALA + ESCALA / 2;

        if (px >= bitmap.Width || py >= bitmap.Height || px < 0 || py < 0)
            return true;

        Color color = bitmap.GetPixel(px, py);
        return color.ToArgb() == Color.Black.ToArgb(); // mismo color del brush
    }
}
