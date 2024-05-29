using Image.MVVM.Views;

namespace Image
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ImageHandleView), typeof(ImageHandleView));
        }
    }
}
