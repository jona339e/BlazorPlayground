using BlazorPlayground.Interfaces;
using BlazorPlayground.Models;

namespace BlazorPlayground.Services
{
    public class ContactServiceTesting : IContactService
    {
        public void AddContact(ContactModel contact)
        {

        }

        public List<ContactModel> GetContact()
        {
            return new List<ContactModel>
             {
                new ContactModel
                {
                    FirstName = "test",
                    LastName = "test",
                    Email = "test@mail.com"
                }
             };
        }
    }
}
