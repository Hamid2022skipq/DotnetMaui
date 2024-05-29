//using Weather_App.MVVM.ViewModels;
using Weather_App.MVVM.Views;
namespace Weather_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
