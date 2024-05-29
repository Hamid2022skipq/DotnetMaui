using Image.MVVM.ViewModels;
namespace Image.MVVM.Views;

public partial class ImageHandleView : ContentPage
{
	public ImageHandleView()
	{
		InitializeComponent();
        BindingContext = new ImageHandleViewModels();
    }
}