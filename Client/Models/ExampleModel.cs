using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class ExampleModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string? Name { get; set; }
    }
}
