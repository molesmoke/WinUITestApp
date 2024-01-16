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

            grid.PointerMoved += Grid_PointerMoved;
            grid.PointerPressed += Grid_PointerPressed;
            grid.PointerReleased += Grid_PointerReleased;
            grid.PointerCanceled += Grid_PointerCanceled;

            grid.KeyDown += Grid_KeyDown;
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            Debug.WriteLine(e.Key);
        }

        private void Grid_PointerMoved(object sender, PointerRoutedEventArgs e) => PrintDebug(e);

        private void Grid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            PrintDebug(e);
            grid.CapturePointer(e.Pointer);
        }

        private void Grid_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            PrintDebug(e);
            grid.ReleasePointerCaptures();
        }

        private void Grid_PointerCanceled(object sender, PointerRoutedEventArgs e) => PrintDebug(e);

        private void PrintDebug(PointerRoutedEventArgs e, [CallerMemberName] string caller = "") => Debug.WriteLineIf(true, $"{caller} {e.Pointer.PointerId} {e.GetCurrentPoint(grid).Position:F1}");
    }

}
