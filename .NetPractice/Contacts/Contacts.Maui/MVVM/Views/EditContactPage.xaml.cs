using Contacts.Maui.MVVM.Models;
using Contact = Contacts.Maui.MVVM.Models.Contacts;
using Contacts.Maui.MVVM.ViewsModels;
namespace Contacts.Maui.MVVM.Views;



[QueryProperty(nameof(contact_Id),"Id")]
public partial class EditContactPage : ContentPage
{		
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

	private void BtnCancelEditContact_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
	public string contact_Id
	{
		set 
		{ 
		contact = UserContact.GetContactById(int.Parse(value));
			//lblName.Text = contact.Name;
			contactCtrl.Name = contact.Name;
			contactCtrl.Email = contact.Email;
			contactCtrl.Phone= contact.Phone;
            contactCtrl.Address = contact.Address;
		}
	}

    private void BtnUpdateEditContact_Clicked(object sender, EventArgs e)
    {
        string email = contactCtrl.Email;
        contact.Name = contactCtrl.Name;
        contact.Email = contactCtrl.Email;
        contact.Phone = contactCtrl.Phone;
        contact.Address = contactCtrl.Address;

        UserContact.UpdateContact(contact.ContactId, contact);
		Shell.Current.GoToAsync(nameof(ContactsPage));

    }
}