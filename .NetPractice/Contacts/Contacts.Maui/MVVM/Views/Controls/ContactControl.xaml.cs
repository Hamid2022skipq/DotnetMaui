namespace Contacts.Maui.MVVM.Views.Controls;

public partial class ContactControl : ContentView
{ 

    public event EventHandler<EventArgs> OnSave;
    public event EventHandler<EventArgs> OnCancle;
    public ContactControl()
	{
		InitializeComponent();
	}
	public string Name
	{
		get
		{
			return entryName.Text;
		}
		set
		{
			entryName.Text = value;
		}
	}
    public string Email
    {
        get
        {
            return entryEmail.Text;
        }
        set
        {
            entryEmail.Text = value;
        }
    }
    public string Phone
    {
        get
        {
            return entryPhone.Text;
        }
        set
        {
            entryPhone.Text = value;
        }
    }
    public string Address
    {
        get
        {
            return entryAddress.Text;
        }
        set
        {
            entryAddress.Text = value;
        }
    }

    private async void BtnSave_Clicked(object sender, EventArgs e)
    {
        try
        {
            OnSave?.Invoke(sender, e);
            await Shell.Current.GoToAsync(nameof(ContactsPage));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Navigation Error: {ex.Message}");
        }
    }

    private void BtnCancelt_Clicked(object sender, EventArgs e)
    {
        OnCancle?.Invoke(sender, e);
    }
}