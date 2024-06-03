using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace OriginPoint_WPF.Model
{
    public class Parameters
    {               
        public StockSize Stock { get; set; }
        public PrintSize Print { get; set; }
        public OriginPoints Origin { get; set; }

        public Parameters(StockSize stockSize, PrintSize printSize, OriginPoints originPoints)
        {
            Stock = stockSize;
            Print = printSize;
            Origin = originPoints;
        }        
        
        public class OriginPoints
        {
            public double Horizontal { get; set; }
            public double Vertical { get; set; }

            public OriginPoints(double horizontal, double vertical)
            {
                Horizontal = horizontal;
                Vertical = vertical;
            }        
        }

        public class PrintSize
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public PrintSize(double width, double height)
            {
                Width = width;
                Height = height;
            }
        }

        public class StockSize
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public StockSize(double width, double height)
            {
                Width = width;
                Height = height;
            }
        }
    }
}

