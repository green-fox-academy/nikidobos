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

            //foxDraw.StrokeColor(Colors.Green);
            //foxDraw.DrawLine(0, 0, canvas.Width, canvas.Height );

            double a = 0;
            double b = 2;
            var startPoint = new Point(a, b);
            var endPoint = new Point(canvas.Width, canvas.Height);
            

            if (a == 0 && b == 0)
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
