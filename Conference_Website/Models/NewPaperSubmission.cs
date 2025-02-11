using System.ComponentModel.DataAnnotations;

namespace Conference_Website.Models
{
    //Paper submission Model
    public class NewPaperSubmission
    {
        [Required(ErrorMessage = "Paper Title is required.")]
        public string Papertitle { get; set; }

        [Required(ErrorMessage = "Author Full Name is required.")]
        public string AuthorFullName { get; set; }

        [Required(ErrorMessage = "Author Number is required.")]
        public long AuthorMobile { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string AuthorEmail { get; set; }

        [Required(ErrorMessage = "Institution Name is required.")]
        public string AuthorInstitution { get; set; }

        [Required(ErrorMessage = "Please select an author category.")]
        public string AuthorCategory { get; set; }

        [Required(ErrorMessage = "Please upload a file.")]
        public IFormFile PaperFile { get; set; }
    }
}
