using BlazorPlayground.Components;
using BlazorPlayground.Interfaces;
using BlazorPlayground.Models;
using BlazorPlayground.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorPlayground.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService ContactService { get; set; }
        private bool IsContactsVisible { get; set; } = true;

        private List<ContactModel> contacts;
        private ContactListComponent contactList;
        private Dictionary<string, object> CustomAttributes { get; set; } // 3rd textbox

        protected override void OnInitialized()
        {


            CustomAttributes = new Dictionary<string, object> // 3rd textbox
        {
            { "disabled", "disabled"},
            { "placeholder", "placeholder 03"},
            { "type", "text"}
        };


        }

        protected async override Task OnInitializedAsync()
        {
            //await Task.Delay(5000); // simulate a delay in loading data
            //contacts = new();
            contacts = ContactService.GetContact();

            base.OnInitializedAsync();
        }

        private void ToggleContacts()
        {
            IsContactsVisible = !IsContactsVisible;
            if (!IsContactsVisible)
            {
                contactList.HideContacts();
            }
            else contactList.ShowContact();
        }

        private DeleteConfirmationComponent deleteConfirmation;

        private void RequestDeleteModal(ContactModel contact)
        {
            deleteConfirmation.Title = "Delete Contact";
            deleteConfirmation.Text = $"Are you sure you want to delete {contact.FirstName} {contact.LastName}?";
            deleteConfirmation.ContactToDelete = contact;
            deleteConfirmation.ShowModal();
        }

        private async Task OnDeleteConfirmed(ContactModel contact)
        {
            contacts.Remove(contact);
            deleteConfirmation.HideModal();
        }

    }
}
