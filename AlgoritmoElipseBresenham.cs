using System;
using System.Threading.Tasks;

public class AlgoritmoElipseBresenham
{
    private PixelDrawer drawer;

    public AlgoritmoElipseBresenham(PixelDrawer pixelDrawer)
    {
        drawer = pixelDrawer;
    }

    private async Task DibujarSimetriaElipse(int xc, int yc, int x, int y)
    {
        await drawer.DibujarPixelAnimado(xc + x, yc + y);
        await drawer.DibujarPixelAnimado(xc - x, yc + y);
        await drawer.DibujarPixelAnimado(xc + x, yc - y);
        await drawer.DibujarPixelAnimado(xc - x, yc - y);
    }

    public async Task DibujarElipseBresenham(int xc, int yc, int rx, int ry)
    {
        int x = 0;
        int y = ry;

        double dx = 2 * ry * ry * x;
        double dy = 2 * rx * rx * y;
        double p1 = ry * ry - rx * rx * ry + 0.25 * rx * rx;

        while (dx < dy)
        {
            await DibujarSimetriaElipse(xc, yc, x, y);
            x++;
            dx = 2 * ry * ry * x;
            if (p1 < 0)
            {
                p1 = p1 + dx + ry * ry;
            }
            else
            {
                y--;
                dy = 2 * rx * rx * y;
                p1 = p1 + dx - dy + ry * ry;
            }
        }

        double p2 = ry * ry * (x + 0.5) * (x + 0.5) + rx * rx * (y - 1) * (y - 1) - rx * rx * ry * ry;

        while (y >= 0)
        {
            await DibujarSimetriaElipse(xc, yc, x, y);
            y--;
            dy = 2 * rx * rx * y;
            if (p2 > 0)
            {
                p2 = p2 - dy + rx * rx;
            }
            else
            {
                x++;
                dx = 2 * ry * ry * x;
                p2 = p2 + dx - dy + rx * rx;
            }
        }
    }
}
