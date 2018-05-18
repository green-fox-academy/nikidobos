using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace Diagonals
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            var p1 = new Point(0, 0);
            var p2 = new Point(canvas.Width, canvas.Height);
            var p3 = new Point(0, canvas.Height);
            var p4 = new Point(canvas.Width, 0);

            DrawLine(p1, p2, foxDraw);
            DrawLine(p3, p4, foxDraw);
        }

        public static void DrawLine(Point startPoint, Point endPoint, FoxDraw foxDraw)
        {
            if ((startPoint.X == 0 && startPoint.Y == 0) || (endPoint.X == 0 && endPoint.Y == 0))
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(startPoint, endPoint);

            }
            else
            {
                foxDraw.StrokeColor(Colors.Red);
                foxDraw.DrawLine(startPoint, endPoint);
            }
        }

    }

}
