using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficos
{
    internal class BezierLines
    {
        private int _cellSize;
        private int _startX;
        private int _endX;
        private int _startY;

        public BezierLines(int startX, int endX, int startY, int cellSize)
        {
            _startX = startX;
            _endX = endX;
            _startY = startY;
            _cellSize = cellSize;
        }

        public void Draw(Graphics g, int numberOfLines)
        {
            using (Pen pen = new Pen(Color.DarkGreen, 2))
            {
                int canvasWidth = _endX;
                int canvasHeight = (int)g.ClipBounds.Height;

                for (int i = 0; i < numberOfLines; i++)
                {
                    int offset = (i + 1) * _cellSize;

                    // Cuadrante superior izquierdo 
                    g.DrawLine(pen, new Point(0, (numberOfLines - i) * _cellSize), new Point(offset, 0));

                    // Cuadrante superior derecho
                    g.DrawLine(pen, new Point(canvasWidth, (numberOfLines - i) * _cellSize), new Point(canvasWidth - offset, 0));

                    // Cuadrante inferior izquierdo
                    g.DrawLine(pen, new Point(0, canvasHeight - (numberOfLines - i) * _cellSize), new Point(offset, canvasHeight));

                    // Cuadrante inferior derecho 
                    g.DrawLine(pen, new Point(canvasWidth, canvasHeight - (numberOfLines - i) * _cellSize), new Point(canvasWidth - offset, canvasHeight));
                }
            }
        }
    }
}
