using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

public class ScanlineFill
{
    private PixelDrawer drawer;

    public ScanlineFill(PixelDrawer pixelDrawer)
    {
        drawer = pixelDrawer;
    }

    public async Task RellenarPoligonoAsync(Point[] vertices)
    {
        if (vertices.Length < 3) return;

        // Encontrar el Y  y máximo
        int yMin = int.MaxValue, yMax = int.MinValue;
        foreach (Point p in vertices)
        {
            if (p.Y < yMin) yMin = p.Y;
            if (p.Y > yMax) yMax = p.Y;
        }

        // Escaneamos cada línea horizontal
        for (int y = yMin; y <= yMax; y++)
        {
            List<int> intersecciones = new List<int>();

            for (int i = 0; i < vertices.Length; i++)
            {
                Point p1 = vertices[i];
                Point p2 = vertices[(i + 1) % vertices.Length];

                if ((p1.Y <= y && p2.Y > y) || (p2.Y <= y && p1.Y > y))
                {
                    float x = p1.X + (float)(y - p1.Y) * (p2.X - p1.X) / (p2.Y - p1.Y);
                    intersecciones.Add((int)x);
                }
            }

            intersecciones.Sort();

            // Rellenar pares de intersecciones
            for (int i = 0; i < intersecciones.Count - 1; i += 2)
            {
                int xStart = intersecciones[i];
                int xEnd = intersecciones[i + 1];
                for (int x = xStart; x <= xEnd; x++)
                {
                    if (!drawer.EstaPintado(x, y))
                        await drawer.DibujarPixelAnimado(x, y);
                }
            }
        }
    }
}
