using System.ComponentModel.DataAnnotations;

namespace Conference_Website.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }
    }
}
