using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;
namespace ImagePicker.MVVM.Views;
public partial class ImagePickerViews : ContentPage
{
	public ImagePickerViews()
    {
		InitializeComponent();
    }

	private async void pickImageButton_Clicked(object sender, EventArgs e)
	{
		PickOptions options = new PickOptions();
		try
		{
			var result = await FilePicker.Default.PickAsync(options);
			if (result != null) {
				if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) || (result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase)));
				var stream = await result.OpenReadAsync();
				var image = ImageSource.FromStream(() => stream);
                ImagePicked = image;
			}
		}
		catch (Exception ex)
        {
			DisplayAlert("Error", ex.Message, "OK");
		}
	}
}