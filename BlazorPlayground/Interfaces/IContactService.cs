using BlazorPlayground.Models;

namespace BlazorPlayground.Interfaces
{
    public interface IContactService
    {
        List<ContactModel> GetContact();
        void AddContact(ContactModel contact);
    }
}
