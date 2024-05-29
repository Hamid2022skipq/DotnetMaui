using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Image.MVVM.ViewModels
{
    public partial class ImageHandleViewModels : ObservableObject
    {
        [ObservableProperty]
        private ImageSource _imagePicked;

        [RelayCommand]
        public async Task PickImageAsync()
        {
            PickOptions options = new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Pick an image"
            };

            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                    {
                        using var stream = await result.OpenReadAsync();
                        ImagePicked = ImageSource.FromStream(() => stream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error picking image: {ex.Message}");
            }
        }
    }
}