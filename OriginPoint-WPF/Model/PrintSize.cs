using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginPoint_WPF.Model
{
    public class PrintSize
    {
        public double Width { get; set; }
        public double Height { get; set; }

        PrintSize(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}
