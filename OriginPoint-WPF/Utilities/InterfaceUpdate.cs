using OriginPoint_WPF.Model;
using System;

namespace OriginPoint_WPF.Utilities
{
    public class InterfaceUpdate
    {
        public double[] TextboxUpdate(Parameters parameters)
        {                   
            return new double[]
            {
                parameters.Stock.Height - (parameters.Print.Height + parameters.Origin.Vertical),     // Remaining Upper
                parameters.Stock.Width - (parameters.Print.Width + parameters.Origin.Horizontal),     // Remaining Left
                parameters.Origin.Horizontal,         // Remaining Right
                parameters.Origin.Vertical,           // Remaining Lower                            
                parameters.Origin.Horizontal,         // Horizontal origin
                parameters.Origin.Vertical            // Vertical origin
            };
        }

        public void ColorUpdate() // maybe change accent color based on flat sheet or roll
        {
            throw new NotImplementedException();
        }
    }
}
