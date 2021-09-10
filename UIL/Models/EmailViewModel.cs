using System.ComponentModel.DataAnnotations;
namespace UIL.Models
{
    public class EmailViewModel
    {
        [Required]
        [StringLength(20,  ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(60, ErrorMessage = "The {0} must be at max {1} characters long.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be at max {1} characters long.")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "The {0} must be at max {1} characters long.")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
