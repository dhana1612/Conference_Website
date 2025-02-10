using Conference_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using static Conference_Website.NewPaperSubmissionDetailscs;

namespace Conference_Website.Controllers
{
    //ContactFormController contain all action method related email
    public class ContactFormController : Controller
    {
        [HttpPost]
        public IActionResult ContactForm(ContactForm details)
        {
            if (!ModelState.IsValid)
            {
                var message = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).FirstOrDefault();
                TempData["Message"] = message;
                TempData["MessageType"] = "danger";
                return Redirect(Url.Action("Index", "Home") + "#contact");
            }

            Email_Client_To_Admin c2a = new Email_Client_To_Admin();
            ResponseEmail re = new ResponseEmail();
            bool responseStatus = c2a.email_Client_To_Admin(details.Email, details.FirstName, details.PhoneNumber, details.Message);
            Console.WriteLine(responseStatus);

            if (responseStatus)
            {
                re.responseEmail(details.Email);
                TempData["Message"] = "Your email has been successfully sent!";
                TempData["MessageType"] = "success";
            }
            else
            {
                TempData["Message"] = "There was an error sending the email. Please try again.";
                TempData["MessageType"] = "danger";
            }

            return Redirect(Url.Action("Index", "Home") + "#contact");
        }

        [HttpPost]
        public IActionResult NewPaperSubmission(NewPaperSubmission details)
        {
            if (!ModelState.IsValid)
            {
                var message = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).FirstOrDefault();
                TempData["Message"] = message;
                TempData["MessageType"] = "danger";
                return RedirectToAction("New_Paper_Submissions", "Author_s_Desk");
            }
            string selectedCategory = details.AuthorCategory;



            NewPaperSubmissionDetailscs e = new NewPaperSubmissionDetailscs();
            ResponseEmail re = new ResponseEmail();

            bool response = e.email_Client_To_Admin(details.Papertitle, details.AuthorFullName, details.AuthorMobile, details.AuthorEmail, details.AuthorInstitution, selectedCategory, details.PaperFile);

            if (response)
            {
                re.responseEmail(details.AuthorEmail);
                TempData["Message"] = "Your email has been successfully sent!";
                TempData["MessageType"] = "success";  
            }
            else
            {
                TempData["Message"] = "There was an error sending the email. Please try again.";
                TempData["MessageType"] = "danger";
            }

            return RedirectToAction("New_Paper_Submissions", "Author_s_Desk");


        }

        [HttpPost]
        public IActionResult ContactForm1(ContactForm details)
        {
            if (!ModelState.IsValid)
            {
                var message = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).FirstOrDefault();
                TempData["Message"] = message;
                TempData["MessageType"] = "danger";
                return Redirect(Url.Action("Contact", "Home") + "#contact");
            }

            Email_Client_To_Admin c2a = new Email_Client_To_Admin();
            ResponseEmail re = new ResponseEmail();
            bool responseStatus = c2a.email_Client_To_Admin(details.Email, details.FirstName, details.PhoneNumber, details.Message);
            Console.WriteLine(responseStatus);

            if (responseStatus)
            {
                re.responseEmail(details.Email);
                TempData["Message"] = "Your email has been successfully sent!";
                TempData["MessageType"] = "success";
            }
            else
            {
                TempData["Message"] = "There was an error sending the email. Please try again.";
                TempData["MessageType"] = "danger";
            }

            return Redirect(Url.Action("Contact", "Home") + "#contact");
        }
    }
}
