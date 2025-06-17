using System;
using System.Threading.Tasks;

public class AlgoritmoDDA
{
    private PixelDrawer drawer;

    public AlgoritmoDDA(PixelDrawer pixelDrawer)
    {
        drawer = pixelDrawer;
    }

    public async Task DibujarLineaDDA(int x1, int y1, int x2, int y2)
    {
        int dx = x2 - x1;
        int dy = y2 - y1;
        int pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));

        float xInc = dx / (float)pasos;
        float yInc = dy / (float)pasos;

        float x = x1;
        float y = y1;

        for (int i = 0; i <= pasos; i++)
        {
            await drawer.DibujarPixelAnimado((int)Math.Round(x), (int)Math.Round(y));
            x += xInc;
            y += yInc;
        }
    }
}
