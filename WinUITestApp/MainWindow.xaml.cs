using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUITestApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            grid.KeyDown += Grid_KeyDown;

            grid.KeyUp += Grid_KeyUp;
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Debug.WriteLine($"KeyDown: {e.Key}");
        }

        private void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            Debug.WriteLine($"KeyUp: {e.Key}");
        }
    }

}
