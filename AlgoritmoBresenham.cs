using System;
using System.Threading.Tasks;

public class AlgoritmoBresenham
{
    private PixelDrawer drawer;

    public AlgoritmoBresenham(PixelDrawer pixelDrawer)
    {
        drawer = pixelDrawer;
    }

    public async Task DibujarLineaBresenham(int x1, int y1, int x2, int y2)
    {
        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);
        int sx = x1 < x2 ? 1 : -1;
        int sy = y1 < y2 ? 1 : -1;
        int err = dx - dy;

        while (true)
        {
            await drawer.DibujarPixelAnimado(x1, y1);
            if (x1 == x2 && y1 == y2) break;

            int e2 = 2 * err;

            if (e2 > -dy)
            {
                err -= dy;
                x1 += sx;
            }

            if (e2 < dx)
            {
                err += dx;
                y1 += sy;
            }
        }
    }
}
