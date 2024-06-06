using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OriginPoint_WPF.Model
{
    public class DrawRectangle
    {
        public static Rectangle StockRectangle(Parameters.StockSize stockSize)
        {
            return CreateRectangle(stockSize.Width, stockSize.Height, Brushes.DimGray, Brushes.LightGray, 10);
        }

        public static Rectangle PrintRectangle(Parameters.PrintSize printSize, Parameters.StockSize stockSize, Parameters.OriginPoints originPoints)
        {
            if (originPoints.Horizontal + printSize.Width > stockSize.Width)
                return CreateRectangle(printSize.Width, printSize.Height, Brushes.DarkRed, new SolidColorBrush(Color.FromArgb(128, 255, 0, 0)), 10);

            return CreateRectangle(printSize.Width, printSize.Height, Brushes.DarkGreen, Brushes.LightGreen, 10);
        }

        public static Rectangle CreateRectangle(double width, double height, Brush stroke, Brush fill, double thickness)
        {
            return new Rectangle
            {
                Width = width,
                Height = height,
                Stroke = stroke,
                Fill = fill,
                StrokeThickness = thickness
            };
        }        
    }
}
