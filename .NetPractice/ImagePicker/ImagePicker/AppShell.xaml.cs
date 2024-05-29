using ImagePicker.MVVM.Views;

namespace ImagePicker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ImagePickerViews), typeof(ImagePickerViews));
        }
    }
}
