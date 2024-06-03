using OriginPoint_WPF.Model;
using OriginPoint_WPF.Utilities;
using System;
using System.Windows;
using System.Windows.Controls;

namespace OriginPoint_WPF.Views
{
    public partial class FlatSheet : UserControl
    {
        public FlatSheet()
        { InitializeComponent(); }

        public event EventHandler<CanvasUpdateEventArgs> CanvasUpdate;

        public void DrawButton_Click(object sender, RoutedEventArgs e)
        {

            var parameters = GetParameters();
            CanvasUpdate?.Invoke(this, new CanvasUpdateEventArgs(parameters));
        }

        public Parameters GetParameters()
        {
            return new Parameters(
                new Parameters.StockSize(DataValidation.ParseTextBox(StockWidthTextBox), DataValidation.ParseTextBox(StockHeightTextBox)),
                new Parameters.PrintSize(DataValidation.ParseTextBox(PrintWidthTextBox), DataValidation.ParseTextBox(PrintHeightTextBox)),
                new Parameters.OriginPoints(DataValidation.ParseTextBox(HorizontalTextBox), DataValidation.ParseTextBox(VerticalTextBox)));
        }

        public class CanvasUpdateEventArgs : EventArgs
        {
            public Parameters Parameters { get; }

            public CanvasUpdateEventArgs(Parameters parameters)
            {
                Parameters = parameters;
            }
        }

    }
}