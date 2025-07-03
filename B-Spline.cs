using System;
using System.Collections.Generic;
using System.Drawing;

namespace AlgoritmosGraficos
{
    internal class B_Spline
    {
        private List<PointF> controlPoints;
        private int grado;

        public B_Spline(List<PointF> puntosDeControl, int grado = 3)
        {
            controlPoints = puntosDeControl;
            this.grado = grado;
        }

        public List<PointF> CalcularBSpline()
        {
            List<PointF> splinePoints = new List<PointF>();

            int n = controlPoints.Count - 1;
            int k = grado;

            if (controlPoints.Count < k + 1)
                return splinePoints;

            List<float> knots = GenerarNudosUniformes(n, k);
            float tMin = knots[k - 1];
            float tMax = knots[n + 1];

            for (float t = tMin; t <= tMax; t += 0.01f)
            {
                PointF punto = DeBoor(k, t, knots);
                splinePoints.Add(punto);
            }

            return splinePoints;
        }

        private List<float> GenerarNudosUniformes(int n, int k)
        {
            int m = n + k + 1;
            List<float> knots = new List<float>();

            for (int i = 0; i <= m; i++)
            {
                knots.Add(i);
            }

            return knots;
        }

        private PointF DeBoor(int k, float t, List<float> knots)
        {
            int n = controlPoints.Count - 1;

            int s = -1;
            for (int i = k; i <= n; i++)
            {
                if (t >= knots[i] && t < knots[i + 1])
                {
                    s = i;
                    break;
                }
            }

            if (s == -1) s = n;

            List<PointF> d = new List<PointF>();
            for (int j = 0; j <= k; j++)
            {
                int idx = s - k + j;
                if (idx < 0) idx = 0;
                if (idx >= controlPoints.Count) idx = controlPoints.Count - 1;
                d.Add(controlPoints[idx]);
            }

            for (int r = 1; r <= k; r++)
            {
                for (int j = k; j >= r; j--)
                {
                    float denom = knots[s + 1 + j - r] - knots[s - k + j];
                    float alpha = denom != 0 ? (t - knots[s - k + j]) / denom : 0;
                    float x = (1 - alpha) * d[j - 1].X + alpha * d[j].X;
                    float y = (1 - alpha) * d[j - 1].Y + alpha * d[j].Y;
                    d[j] = new PointF(x, y);
                }
            }

            return d[k];
        }
    }
}
