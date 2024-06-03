using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OriginPoint_WPF.Utilities
{
    public class UniversalControls
    {
        public static void MinimizeWindow(Window window)
        {
            if (window != null)
                window.WindowState = WindowState.Minimized;
        }

        public static void CloseWindow(Window window)
        {
            if (window != null)
                window.Close();
        }

        public static void DragWindow(Window window, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (window != null && e.ButtonState == System.Windows.Input.MouseButtonState.Pressed)
                window.DragMove();

        }      
    }
}
