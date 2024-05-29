using Contacts.Maui.MVVM.Views;
namespace Contacts.Maui
{
    public partial class AppShell : Shell
    {   
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ContentPage), typeof(ContentPage));
            Routing.RegisterRoute(nameof(AddContactsPage), typeof(AddContactsPage));
            Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));
        }
    }
}
