using ActivityPlannerBlazor.Shared.DTOS;
using ActivityPlannerBlazor.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ActivityPlannerBlazor.Shared.SMTP
{
    public class MailService
    {
        public static void SendMailToCustomer(AttendeeDTO attendee, OrganizerDTO organizer, AppointmentDTO appointment, string pathfile = null)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("testmailopdracht@gmail.com");
                mail.To.Add(attendee.Data.Email);
                mail.Subject = "Activity planner invite";
                mail.Body = MessageGenerator.ReturnMessage(organizer, appointment);
                mail.IsBodyHtml = true;
                if (pathfile != null)
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(pathfile);
                    mail.Attachments.Add(attachment);
                }
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("testmailopdracht@gmail.com", "testmail");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }

            }
        }
    }
}
