using Contact = Contacts.Maui.MVVM.Models.Contacts;
namespace Contacts.Maui.MVVM.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Contacts.Maui.MVVM.Models;
using Contacts.Maui.MVVM.ViewsModels;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContact();
    }


    private void BtnEditContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));

    }

    private void BtnAddContacts_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactsPage));
    }

    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (ListContacts.SelectedItem != null)
        {
           await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={ ((Contact)ListContacts.SelectedItem).ContactId}");
        }
    }

    private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListContacts.SelectedItem = null;
    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactsPage));
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactsPage));
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        var menuItem = (MenuItem)sender;
        var contact = (Contact)menuItem.CommandParameter;
        var contactId = contact.ContactId;
        UserContact.DeleteContact(contactId);
        LoadContact();
    }
    private void LoadContact()
    {
        var contacts = new ObservableCollection<Contact>(UserContact.GetContacts());
        ListContacts.ItemsSource = contacts;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
       var contactList = new ObservableCollection<Contact>(UserContact.SearchContacts(((SearchBar)sender).Text));
        ListContacts.ItemsSource = contactList;
    }
}