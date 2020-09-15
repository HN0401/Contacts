using System.Collections.Generic;
using Contacts.Models;

namespace Contacts.Data
{
    public interface IContactRepo
    {
        IEnumerable<Contact> GetAllContacts();

        Contact GetContactById(int id);
    }
}