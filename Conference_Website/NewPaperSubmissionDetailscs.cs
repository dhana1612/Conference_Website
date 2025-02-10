using System.Net.Mail;

namespace Conference_Website
{
    public class NewPaperSubmissionDetailscs
    {

        //Client Submit there paper to author through mail
        public bool email_Client_To_Admin(string papertitle, string Authorfullname, long authormobile, string authoremail, string authorinstution, string authorcategory, IFormFile formfile)
            {
                try
                {
                    MailMessage newMail = new MailMessage();
                    SmtpClient client = new SmtpClient("smtp.gmail.com");

                    // Email is sent from the admin's email
                    newMail.From = new MailAddress("dhanasekar16.bit@gmail.com", "Paper Submission");

                    // Admin receives the email
                    newMail.To.Add("dhanasekar16.bit@gmail.com");

                    // "Reply-To" ensures the admin can reply directly to the user's email
                    newMail.ReplyToList.Add(new MailAddress(authoremail));

                newMail.Subject = $"Paper Submission - {papertitle}";
                newMail.IsBodyHtml = true;
                newMail.Body = $"<h3></h3>" +
                               $"<p>Dear Jack Deniel,</p>" +
                               $"<p>I trust this email finds you well. A user has submitted a concern related to the conference website. Please find the details below for your reference:</p>" +
                               $"<p><b>Email Address:</b> {authoremail}</p>" +
                               $"<p><b>Phone Number:</b> {authormobile}</p>" +
                               $"<p><b>Institution:</b> {authorinstution}</p>" +
                               $"<p><b>Category:</b> {authorcategory}</p>" +
                               $"<p>If you require any further information or clarification, please feel free to reach out.</p>" +
                               $"<p>Best regards,</p>" +
                               $"<p>{Authorfullname}</p>";


                // Attach the PDF file
                if (formfile != null && formfile.Length > 0)
                    {
                        var stream = formfile.OpenReadStream(); // ✅ Do not use 'using' here
                        var attachment = new Attachment(stream, formfile.FileName, formfile.ContentType);
                        newMail.Attachments.Add(attachment);
                    }

                    // SMTP settings
                    client.EnableSsl = true;
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("dhanasekar16.bit@gmail.com", "ijhk pswb yepk zdmo");

                    // Send the email
                    client.Send(newMail);

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error - " + ex.Message);
                    return false;
                }

            }
        
    }
}
