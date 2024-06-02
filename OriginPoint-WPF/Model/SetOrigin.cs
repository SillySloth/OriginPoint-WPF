using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OriginPoint_WPF.Model
{
    public class SetOrigin
    {             
        public enum Position
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

        private void SetUpperLeft(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.UpperLeft);
        }

        private void SetUpper(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.Upper);
        }

        private void SetUpperRight(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.UpperRight);
        }

        private void SetLeft(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.Left);
        }

        private void SetCenter(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.Center);
        }

        private void SetRight(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.Right);
        }

        private void SetLowerLeft(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.LowerLeft);
        }

        private void SetLower(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.Lower);
        }

        private void SetLowerRight(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.LowerRight);
        }
        private void SetCustom(object sender, RoutedEventArgs e)
        {
            SetPosition(Position.Custom);
        }

        private void SetPosition(Position position)
        {
            switch (position)
            {
                case Position.UpperLeft:                    
                    break;
                case Position.Upper:                    
                    break;
                case Position.UpperRight:                    
                    break;
                case Position.Left:                    
                    break;
                case Position.Center:                    
                    break;
                case Position.Right:                    
                    break;
                case Position.LowerLeft:                    
                    break;
                case Position.Lower:                    
                    break;
                case Position.LowerRight:                    
                    break;
                case Position.Custom:                    
                    break;
                default:
                    break;
            }
        }

        public void calculateOrigin()
        {
            // Work out the origin points
        }
    }
}
