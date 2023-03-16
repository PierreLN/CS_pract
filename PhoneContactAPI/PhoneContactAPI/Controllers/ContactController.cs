using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneContactAPI.Data;
using PhoneContactAPI.Models;

namespace PhoneContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ContactDbContext _context;
        public ContactController(ContactDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Contact>> Get() => await _context.Contact.ToListAsync();
    }
}


