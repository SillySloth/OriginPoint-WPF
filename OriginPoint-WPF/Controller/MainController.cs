using OriginPoint_WPF.Views;
using System.DirectoryServices.ActiveDirectory;
using static OriginPoint_WPF.Views.FlatSheet;

namespace OriginPoint_WPF.Controllers
{
    public class MainController
    {
        private readonly FlatSheet _flatSheetView;
        private readonly DrawingCanvas _drawingCanvasView;

        public MainController(FlatSheet flatSheetView, DrawingCanvas drawingCanvasView)
        {
            _flatSheetView = flatSheetView;
            _drawingCanvasView = drawingCanvasView;

            // Subscribe to the CanvasUpdate event in FlatSheet
            _flatSheetView.CanvasUpdate += OnCanvasUpdate;
        }

        private void OnCanvasUpdate(object sender, CanvasUpdateEventArgs e)
        {
            // Update the DrawingCanvas with values from FlatSheet
            _drawingCanvasView.UpdateValues(e.Parameters);
        }
        
    }
}
