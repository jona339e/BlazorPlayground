using BlazorPlayground.Interfaces;
using BlazorPlayground.Models;

namespace BlazorPlayground.Services
{
    public class ContactService : IContactService
    {
        private List<ContactModel> ContactList = new List<ContactModel>
            {
                new ContactModel { FirstName = "John", LastName = "Doe", Email = "JoD@mail.com" },
                new ContactModel { FirstName = "Jane", LastName = "Doe", Email = "JaD@mail.com" },
                new ContactModel { FirstName = "James", LastName = "Doe", Email = "JamD@mail.com" }
            };

        public List<ContactModel> GetContact()
        {
            return ContactList;
        }
        public void AddContact(ContactModel contact)
        {
            ContactList.Add(contact);
        }
    }
}
