
namespace FlipViewContextPreview01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            DataContext = new SampleData();
            InitializeComponent();

            // TODO testme only
            WinRTXamlToolkit.Debugging.DC.ShowVisualTree();
        }
    }
}
