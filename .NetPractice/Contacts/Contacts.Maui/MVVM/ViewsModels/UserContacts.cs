using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact = Contacts.Maui.MVVM.Models.Contacts;

namespace Contacts.Maui.MVVM.ViewsModels
{
    public static class UserContact
    {
        public static readonly List<Contact> contacts = [
        new() {ContactId=1, Name="Yasir Ali",Email="YasirAli@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        new() {ContactId=2, Name="Imran Ali",Email="ImranAli@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        new() {ContactId=3, Name="Rizwan Ali",Email="RizwanAli@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        new() {ContactId=4, Name="Hamid Ali",Email="HamidAli@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        new() {ContactId=5, Name="Ali Raza",Email="AliRaza@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        new() {ContactId=6, Name="Muzammil",Email="muzammil@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        new() {ContactId=7, Name="Yasir Ali Bhai",Email="YasirAlione@email.com",Phone="123456789",Address="51600, punjab pakistan"},
        ];
        public static List<Contact> GetContacts() => contacts;
        public static Contact? GetContactById(int ID)
        {
            var contact = contacts.FirstOrDefault(obj => obj.ContactId == ID);
            if (contact != null)
            {
                return new Contact
                {
                    ContactId = ID,
                    Address = contact.Address,
                    Name = contact.Name,
                    Email = contact.Email,
                    Phone = contact.Phone

                };
            }
            return null;
        }
        public static void UpdateContact(int contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;
            var ContactToUpdate = contacts.FirstOrDefault(obj => obj.ContactId == contactId);
            if (ContactToUpdate != null)
            {
                ContactToUpdate.Name = contact.Name;
                ContactToUpdate.Email = contact.Email;
                ContactToUpdate.Phone = contact.Phone;
                ContactToUpdate.Address = contact.Address;
            }
        }
        public static void AddContact(Contact contact)
        {
            var maxId = contacts.Max(x => x.ContactId);
            contact.ContactId = maxId + 1;
            contacts.Add(contact);
        }
        public static void DeleteContact(int Id)
        {
            var contact = contacts.FirstOrDefault(obj => obj.ContactId == Id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
        }
        public static List<Contact> SearchContacts(string text)
        {
            List<Contact>? _contacts = contacts.Where(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();

            if (_contacts == null || _contacts.Count <= 0)
            {
                _contacts = contacts.Where(x => !string.IsNullOrWhiteSpace(x.Email) && x.Email.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (_contacts == null || _contacts.Count <= 0)
            {
                _contacts = contacts.Where(x => !string.IsNullOrWhiteSpace(x.Phone) && x.Phone.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (_contacts == null || _contacts.Count <= 0)
            {
                _contacts = contacts.Where(x => !string.IsNullOrWhiteSpace(x.Address) && x.Address.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return _contacts;
        }


    }
}
