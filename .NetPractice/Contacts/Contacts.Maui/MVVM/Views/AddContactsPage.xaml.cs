using Contacts.Maui.MVVM.ViewsModels;
namespace Contacts.Maui.MVVM.Views;


public partial class AddContactsPage : ContentPage
{
    public AddContactsPage()
	{
		InitializeComponent();
	}

    private void BtnCancelAddContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
    
    private void contactCtrl_OnSave(object sender, EventArgs e)
    {
            UserContact.AddContact(new MVVM.Models.Contacts
        {
                Name = contactCtrl.Name,
                Email = contactCtrl.Email,
                Phone = contactCtrl.Phone,
                Address = contactCtrl.Address,
        });
        Shell.Current.GoToAsync(nameof(ContactsPage));

    }

    private void contactCtrl_OnCancle(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ContactsPage));
    }
}