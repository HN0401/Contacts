using System.Collections.Generic;
using Contacts.Data;
using Contacts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactRepo _repo;

        public ContactController(IContactRepo repo)
        {
            _repo = repo;
        }

        // api/contacts
        [HttpGet]

        public ActionResult<IEnumerable<Contact>> GetAllContacts()
        {
            var contacts = _repo.GetAllContacts();
            return Ok(contacts);
        }

        // api/contacts/4
        [HttpGet("{id}")]
        public ActionResult<Contact> GetContactById(int id)
        {
            var contact = _repo.GetContactById(id);
            return Ok(contact);
        }
    }
}