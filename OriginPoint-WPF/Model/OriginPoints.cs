using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginPoint_WPF.Model
{
    public class OriginPoints
    {
        public double Horizontal { get; set; }
        public double Vertical { get; set; }

        OriginPoints(double horizontal, double vertical)
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }
    }
}
