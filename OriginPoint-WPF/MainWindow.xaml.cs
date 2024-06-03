using OriginPoint_WPF.Controllers;
using OriginPoint_WPF.Utilities;
using OriginPoint_WPF.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OriginPoint_WPF
{   
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            InitializeComponent();
            InitializeController();
        }         

        // Buttons
        public void CloseButton_Click(object sender, RoutedEventArgs e)
        { UniversalControls.CloseWindow(this); }
        public void MinimizeButton_Click(object sender, RoutedEventArgs e)
        { UniversalControls.MinimizeWindow(this); }
        public void DragWindow(object sender, MouseButtonEventArgs e)
        { UniversalControls.DragWindow(this, e); }               
        private void FlatSheetButton_Click(object sender, RoutedEventArgs e)
        { ContentArea.Content = new FlatSheet(); }
        private void RollToRollButton_Click(object sender, RoutedEventArgs e)
        { ContentArea.Content = new RollToRoll(); }
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Settings settingsWindow = new Settings();

            settingsWindow.Owner = this;
            settingsWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            settingsWindow.Left = this.Left + 10; 
            settingsWindow.Top = this.Top + 70;

            settingsWindow.ShowDialog();
        }

        // Main Controller
        private MainController mainController;
        private void InitializeController()
        {
            mainController = new MainController(FlatSheetControl, DrawingCanvasControl);
        }


    }
}