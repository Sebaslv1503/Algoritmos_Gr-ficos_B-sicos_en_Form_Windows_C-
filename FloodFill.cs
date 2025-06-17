using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

public class FloodFill
{
    private PixelDrawer drawer;
    private HashSet<Point> visitados;

    public FloodFill(PixelDrawer pixelDrawer)
    {
        drawer = pixelDrawer;
        visitados = new HashSet<Point>();
    }

    public async Task RellenarAsync(int x, int y)
    {
        visitados.Clear();
        await Flood(x, y);
    }

    private async Task Flood(int x, int y)
    {
        Queue<Point> cola = new Queue<Point>();
        cola.Enqueue(new Point(x, y));

        while (cola.Count > 0)
        {
            Point actual = cola.Dequeue();

            if (visitados.Contains(actual))
                continue;

            if (actual.X < 0 || actual.Y < 0 || actual.X >= drawer.AnchoCanvas || actual.Y >= drawer.AltoCanvas)
                continue;

            if (drawer.EstaPintado(actual.X, actual.Y))
                continue;

            await drawer.DibujarPixelAnimado(actual.X, actual.Y);
            visitados.Add(actual);

            cola.Enqueue(new Point(actual.X + 1, actual.Y)); // Este
            cola.Enqueue(new Point(actual.X - 1, actual.Y)); // Oeste
            cola.Enqueue(new Point(actual.X, actual.Y + 1)); // Sur
            cola.Enqueue(new Point(actual.X, actual.Y - 1)); // Norte
        }
    }
}
