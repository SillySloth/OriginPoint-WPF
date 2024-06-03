using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginPoint_WPF.Model
{
    public class SetSettings
    {
        public SetSettings() 
        {
            SetBedSize SetBedSize = new SetBedSize(3200, 2030);
            SetDefaultStockEdgeDistance SetDefaultStockEdgeDistance = new SetDefaultStockEdgeDistance(0, 0);
            SetDefaultPrintEdgeDistance SetDefaultPrintEdgeDistance = new SetDefaultPrintEdgeDistance(25, 25);
            SetDefaultRollVerticalOrigin SetDefaultRollVerticalOrigin = new SetDefaultRollVerticalOrigin(400);
            SetNegativeOrigins SetNegativeOrigins = new SetNegativeOrigins(true, true);
            SetLanguage Setlanguage = new SetLanguage("English");
            SetDefaultUnits setDefaultUnits = new SetDefaultUnits("Metric");
        }
        
        public class SetBedSize
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public SetBedSize(double width, double height)
            {
                Width = width;
                Height = height;
            }
        }

        public class SetDefaultStockEdgeDistance
        {
            public double Horizontal { get; set; }
            public double Vertical { get; set; }

            public SetDefaultStockEdgeDistance(double horizontal, double vertical)
            {
                Horizontal = horizontal;
                Vertical = vertical;
            }
        }

        public class SetDefaultPrintEdgeDistance
        {
            public double Horizontal { get; set; }
            public double Vertical { get; set; }

            public SetDefaultPrintEdgeDistance(double horizontal, double vertical)
            {
                Horizontal = horizontal;
                Vertical = vertical;
            }

        }

        public class SetDefaultRollVerticalOrigin
        {            
            public double Vertical { get; set; }

            public SetDefaultRollVerticalOrigin(double vertical)
            {                
                Vertical = vertical;
            }
        }

        public class SetNegativeOrigins
        { 
            public bool Horizontal { get; set; }
            public bool Vertical { get; set; }

            public SetNegativeOrigins(bool horizontal, bool vertical)
            {
                Horizontal = horizontal;
                Vertical = vertical;
            }
        } 

        public class SetLanguage
        { 
            public string Language { get; set; }

            public SetLanguage(string language)
            {
                Language = language;
            }
        }
        public class SetDefaultUnits
        { 
            public string Units { get; set; }

            public SetDefaultUnits(string units)
            {
                Units = units;
            }
        }

    }
}
