namespace OriginPoint_WPF.Model
{
    public class CanvasUpdateEventArgs : EventArgs
    {
        public Parameters Parameters { get; }

        public CanvasUpdateEventArgs(Parameters parameters)
        {
            Parameters = parameters;
        }
    }
}
