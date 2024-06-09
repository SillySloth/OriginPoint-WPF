using Microsoft.VisualBasic;
using OriginPoint_WPF.Model;
using OriginPoint_WPF.Utilities;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace OriginPoint_WPF.Views
{
    public partial class FlatSheet : UserControl
    {
        public FlatSheet()
        { InitializeComponent(); }

        public event EventHandler<CanvasUpdateEventArgs> CanvasUpdate;


        public void SetOriginButton_Click(object sender, RoutedEventArgs e)
        {
            Position.Placement placement;    
            InterfaceUpdate InterfaceUpdate = new InterfaceUpdate();

            double stockWidth = DataValidation.ParseTextBox(StockWidthTextBox), stockHeight = DataValidation.ParseTextBox(StockHeightTextBox);
            double printWidth = DataValidation.ParseTextBox(PrintWidthTextBox), printHeight = DataValidation.ParseTextBox(PrintHeightTextBox);
            double horizontal = DataValidation.ParseTextBox(HorizontalTextBox), vertical = DataValidation.ParseTextBox(VerticalTextBox);

            if (sender is Button button)
            {
                if (Enum.TryParse(button.Name, out placement))
                {
                    Parameters parameters = Position.SetPosition(placement, stockWidth, stockHeight, printWidth, printHeight, horizontal, vertical);
                    double[] remainingSpace = InterfaceUpdate.TextboxUpdate(parameters);

                    RemainingSpaceUpper.Text = remainingSpace[0].ToString(); 
                    RemainingSpaceLeft.Text = remainingSpace[1].ToString(); 
                    RemainingSpaceRight.Text = remainingSpace[2].ToString(); 
                    RemainingSpaceLower.Text = remainingSpace[3].ToString();
                    
                    HorizontalTextBox.Text = remainingSpace[4].ToString(); 
                    VerticalTextBox.Text = remainingSpace[5].ToString();

                    CanvasUpdate?.Invoke(this, new CanvasUpdateEventArgs(parameters));
                }               
            }
            else if (sender is RadioButton radiobutton)
            {
                if (Enum.TryParse(radiobutton.Name, out placement))
                {
                    Parameters parameters = Position.SetPosition(placement, stockWidth, stockHeight, printWidth, printHeight, horizontal, vertical);
                    double[] remainingSpace = InterfaceUpdate.TextboxUpdate(parameters);

                    RemainingSpaceUpper.Text = remainingSpace[0].ToString();
                    RemainingSpaceLeft.Text = remainingSpace[1].ToString();
                    RemainingSpaceRight.Text = remainingSpace[2].ToString(); 
                    RemainingSpaceLower.Text = remainingSpace[3].ToString();
                    HorizontalTextBox.Text = remainingSpace[4].ToString();
                    VerticalTextBox.Text = remainingSpace[5].ToString();

                    CanvasUpdate?.Invoke(this, new CanvasUpdateEventArgs(parameters));
                }               
            }
            else
            {
                MessageBox.Show("Failed parse message or something?");
            }
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