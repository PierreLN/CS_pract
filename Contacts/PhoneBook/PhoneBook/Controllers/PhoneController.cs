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

        [HttpGet("id")]
        [ProducesResponseType(typeof(Phone), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetById(int id)
        {
            var phone = await _context.Phones.FindAsync(id);
            return phone == null? NotFound() : Ok(phone);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Phone phone)
        {
            await _context.Phones.AddAsync(phone);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id = phone.Id}, phone);   
        }


    }
}
