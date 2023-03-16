using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly PhoneDbContext _context;
        public PhoneController(PhoneDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Phone>> Get() => await _context.Phones.ToListAsync();
    }
}
