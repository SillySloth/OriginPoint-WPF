using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OriginPoint_WPF.Model
{
    public class DrawShapes
    {             
        DrawShapes()
        {
            // Draw shaps 

        }
        
        public static object DrawStock(StockSize stocksize, OriginPoints originPoints)
        {
            return DrawRectangle(stocksize.Width, stocksize.Height, Brushes.DimGray, Brushes.LightGray, 10);           
        }

        public static object DrawPrint(PrintSize printSize, OriginPoints originPoints)
        {
            var positivePrint = DrawRectangle(printSize.Width, printSize.Height, Brushes.Black, Brushes.White, 10);

            var negativePrint = DrawRectangle(printSize.Width, printSize.Height, Brushes.Black, Brushes.White, 10);
            
            // if else statement to determine if print is in bounds or out of bounds

            return positivePrint; //temporary return value
           

        }

        public static object DrawRectangle(double width, double height, Brush stroke, Brush fill, double thickness)
        {
            var rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Stroke = stroke,
                Fill = fill,
                StrokeThickness = thickness
            };
            return rectangle;

        }
    }
}
