using System;
using System.Threading.Tasks;

public class AlgoritmoCirculoBresenham
{
    private PixelDrawer drawer;

    public AlgoritmoCirculoBresenham(PixelDrawer pixelDrawer)
    {
        drawer = pixelDrawer;
    }

    private async Task DibujarOchoSimetrias(int xc, int yc, int x, int y)
    {
        await drawer.DibujarPixelAnimado(xc + x, yc + y);
        await drawer.DibujarPixelAnimado(xc - x, yc + y);
        await drawer.DibujarPixelAnimado(xc + x, yc - y);
        await drawer.DibujarPixelAnimado(xc - x, yc - y);
        await drawer.DibujarPixelAnimado(xc + y, yc + x);
        await drawer.DibujarPixelAnimado(xc - y, yc + x);
        await drawer.DibujarPixelAnimado(xc + y, yc - x);
        await drawer.DibujarPixelAnimado(xc - y, yc - x);
    }
    public async Task RellenarCirculo(int xc, int yc, int radio)
    {
        // Itera sobre cada fila (Y)
        for (int y = -radio; y <= radio; y++)
        {
            for (int x = -radio; x <= radio; x++)
            {
                if (x * x + y * y <= radio * radio)
                {
                    await drawer.DibujarPixelAnimado(xc + x, yc + y);
                }
            }
        }
    }

    public async Task DibujarCircunferenciaBresenham(int xc, int yc, int radio)
    {
        int x = 0;
        int y = radio;
        int d = 3 - 2 * radio;

        await DibujarOchoSimetrias(xc, yc, x, y);

        while (y >= x)
        {
            x++;

            if (d > 0)
            {
                y--;
                d = d + 4 * (x - y) + 10;
            }
            else
            {
                d = d + 4 * x + 6;
            }

            await DibujarOchoSimetrias(xc, yc, x, y);
        }
    }
}
