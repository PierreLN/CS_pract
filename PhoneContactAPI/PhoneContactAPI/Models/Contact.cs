using System.ComponentModel.DataAnnotations;

namespace PhoneContactAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public double PhoneNumber { get; set; }
        public string? Email { get; set; }
        public double? homeNumber { get; set; }
        public string? Address { get; set; }
    }
}
