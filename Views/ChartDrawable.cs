using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics;


namespace BrownianMotionAPP.Views
{
    public class ChartDrawable : IDrawable
    {
        private readonly double[] _data;

        public ChartDrawable(double[] data)
        {
            _data = data;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (_data == null || _data.Length == 0) return;

            canvas.StrokeColor = Colors.Blue;
            canvas.StrokeSize = 2;

            float width = dirtyRect.Width;
            float height = dirtyRect.Height;

            float stepX = width / _data.Length;
            float scaleY = height / (float)_data.Max();

            for (int i = 0; i < _data.Length - 1; i++)
            {
                float x1 = i * stepX;
                float y1 = height - ((float)_data[i] * scaleY);
                float x2 = (i + 1) * stepX;
                float y2 = height - ((float)_data[i + 1] * scaleY);

                canvas.DrawLine(x1, y1, x2, y2);
            }
        }
    }
}
