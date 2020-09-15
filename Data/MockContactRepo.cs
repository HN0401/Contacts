using System.Collections.Generic;
using Contacts.Models;

namespace Contacts.Data
{
    public class MockContactRepo : IContactRepo
    {
        public IEnumerable<Contact> GetAllContacts()
        {
            var contacts = new List<Contact> {
                new Contact {Id=0, Name= "Vanica", Email= "v@mail.com"},
                new Contact {Id=1, Name="Faye", Email="f@mail.com"},
                new Contact {Id=2, Name="Celty", Email="c@mail.com"}
            };

            return contacts;
        }

        public Contact GetContactById(int id)
        {
            return new Contact { Id = 2, Name = "Lou", Email = "L@mail.com" };
        }
    }
}