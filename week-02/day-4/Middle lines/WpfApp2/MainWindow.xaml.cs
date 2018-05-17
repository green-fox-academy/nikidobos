using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;
using System.Windows.Controls;
using GreenFox;

namespace Drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 225, 800, 225);

            //var startPoint = new Point(0, 20);
            //var endPoint = new Point(100, 20);
            //foxDraw.DrawLine(startPoint, endPoint);


            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(400, 0, 400, 450);

            //var startPoint1 = new Point(120, 200);
            //var endPoint1 = new Point(120, 200);
            //foxDraw.DrawLine(startPoint1, endPoint1);


        }

    }
}
