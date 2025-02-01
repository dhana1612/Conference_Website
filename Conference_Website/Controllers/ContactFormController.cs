using Conference_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conference_Website.Controllers
{
    public class ContactFormController : Controller
    {
        [HttpPost]
        public bool ContactForm(ContactForm details)
        {
            Email_Client_To_Admin c2a = new Email_Client_To_Admin();
            bool responseStatus = c2a.email_Client_To_Admin(details.Email, details.FirstName, details.PhoneNumber, details.Message);
            Console.WriteLine(responseStatus);

            return (responseStatus);
        }


    }
}
