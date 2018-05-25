using GreenFox;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Triangles
{
    public class Square
    {        
        public void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Transparent);
            foxDraw.DrawRectangle(0.25 * foxDraw.Canvas.Width, 0.25 * foxDraw.Canvas.Height, 0.25 * foxDraw.Canvas.Width, 0.25 * foxDraw.Canvas.Height, 15);
        }
    }
}
