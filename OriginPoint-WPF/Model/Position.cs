using System;
using System.Windows;
using OriginPoint_WPF.Model;

namespace OriginPoint_WPF.Model
{
    public class Position
    {
        public enum Placement
        { 
            UpperLeft, 
            Upper, 
            UpperRight,
            Left, 
            Center, 
            Right, 
            LowerLeft, 
            Lower, 
            LowerRight, 
            Custom 
        }

        public static Parameters SetPosition(Placement placement, double StockWidth, double StockHeight, double PrintWidth, double PrintHeight, double Horizontal, double Vertical) 
        {
            Parameters parameters = null;
            double                 
                tempSpacetoEdge = 25, // pull horizontal and verical spacing from settings later
                horizontalCenter = (StockWidth - PrintWidth) / 2, 
                verticalCenter = (StockHeight - PrintHeight) / 2,
                remainingVertical = StockHeight - (PrintHeight + tempSpacetoEdge),
                remainingHorizontal = StockWidth - (PrintWidth + tempSpacetoEdge);
            
            
            switch (placement)
            {
                case Placement.UpperLeft:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(remainingHorizontal, remainingVertical));
                    break;

                case Placement.Upper:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(horizontalCenter, remainingVertical));
                    break;

                case Placement.UpperRight:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(tempSpacetoEdge, remainingVertical));
                    break;

                case Placement.Left:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(remainingHorizontal, verticalCenter));
                    break;

                case Placement.Center:                   
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(horizontalCenter, verticalCenter));
                    break;

                case Placement.Right:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(tempSpacetoEdge, verticalCenter));
                    break;

                case Placement.LowerLeft:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(remainingHorizontal, tempSpacetoEdge));
                    break;

                case Placement.Lower:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(horizontalCenter, tempSpacetoEdge));
                    break;

                case Placement.LowerRight:
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(tempSpacetoEdge, tempSpacetoEdge));
                    break;

                case Placement.Custom:                   
                    parameters = new Parameters(
                        new Parameters.StockSize(StockWidth, StockHeight), 
                        new Parameters.PrintSize(PrintWidth, PrintHeight), 
                        new Parameters.OriginPoints(Horizontal, Vertical));
                    break;
                default:
                    break;
            }
            return parameters;
        }             
    }
}
