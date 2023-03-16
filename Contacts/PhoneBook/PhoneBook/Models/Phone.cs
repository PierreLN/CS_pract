using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Created { get; set; }
    }
}
