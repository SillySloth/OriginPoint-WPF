using OriginPoint_WPF.Model;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using static OriginPoint_WPF.Views.FlatSheet;

namespace OriginPoint_WPF.Views
{
    public partial class DrawingCanvas : UserControl
    {
        public DrawingCanvas()
        { InitializeComponent(); }

        public void UpdateValues(Parameters parameters)
        {
            var stockRectangle =  DrawRectangle.StockRectangle(parameters.Stock);
            var printRectangle =  DrawRectangle.PrintRectangle(parameters.Print, parameters.Stock, parameters.Origin);          
            
            Canvas.SetRight(stockRectangle, 0);
            Canvas.SetBottom(stockRectangle, 0);
            Canvas.SetRight(printRectangle, parameters.Origin.Horizontal);
            Canvas.SetBottom(printRectangle, parameters.Origin.Vertical);

            drawingCanvas.Children.Clear(); // Clear previous drawings if necessary
            drawingCanvas.Children.Add(stockRectangle);
            drawingCanvas.Children.Add(printRectangle);
        }
    }
}
