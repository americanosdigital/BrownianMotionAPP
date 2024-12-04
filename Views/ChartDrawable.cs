using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics;


namespace BrownianMotionAPP.Views
{
    public class ChartDrawable : IDrawable
    {
        private readonly double[] _data;
        private float _scaleX = 1f;
        private float _scaleY = 1f;

        public ChartDrawable(double[] data)
        {
            _data = data;
        }

        public void SetZoom(float scaleX, float scaleY)
        {
            _scaleX = Math.Max(0.5f, Math.Min(5f, scaleX)); // Limite de 0.5x a 5x
            _scaleY = Math.Max(0.5f, Math.Min(5f, scaleY));
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (_data == null || _data.Length == 0) return;

            float width = dirtyRect.Width;
            float height = dirtyRect.Height;

            canvas.SaveState();

            // Verifique o fator de escala para garantir que o gráfico se ajuste ao tamanho da tela
            float maxDataValue = (float)_data.Max();
            float scaleX = width / _data.Length;  // Ajuste para a largura
            float scaleY = maxDataValue > 0 ? height / maxDataValue : 1;  // Ajuste para a altura, evitando divisão por 0

            // Mover o gráfico para o centro da tela
            canvas.Translate(width / 2, height / 2);

            // Aplicar a escala
            canvas.Scale(_scaleX, _scaleY);

            // Mover o gráfico de volta para a posição original
            canvas.Translate(-width / 2, -height / 2);

            // Desenhar linhas de grade
            DrawGrid(canvas, width, height);

            // Desenhar gráfico
            canvas.StrokeColor = Colors.Blue;
            canvas.StrokeSize = 2;

            for (int i = 0; i < _data.Length - 1; i++)
            {
                float x1 = i * scaleX;
                float y1 = height - ((float)_data[i] * scaleY);
                float x2 = (i + 1) * scaleX;
                float y2 = height - ((float)_data[i + 1] * scaleY);

                canvas.DrawLine(x1, y1, x2, y2);
            }

            canvas.RestoreState();
        }


        private void DrawGrid(ICanvas canvas, float width, float height)
        {
            canvas.StrokeColor = Colors.Gray;
            canvas.StrokeSize = 1;

            float verticalStep = width / 5;
            for (int i = 1; i < 5; i++)
            {
                float x = i * verticalStep;
                canvas.DrawLine(x, 0, x, height);
            }

            float horizontalStep = height / 5;
            for (int i = 1; i < 5; i++)
            {
                float y = i * horizontalStep;
                canvas.DrawLine(0, y, width, y);
            }
        }
    }

}
