using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginPoint_WPF.Model
{
    public class StockSize
    {
        public double Width { get; set; }
        public double Height { get; set; }

        StockSize(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
