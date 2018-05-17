using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using FoxDrawNameSpace;

namespace FoxDrawTemplate1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw a box that has different colored lines on each edge.

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(200, 100, 500, 100);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 300, 500, 300);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(200, 100, 200, 300);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(500, 100, 500, 300);

        }
    }

}
