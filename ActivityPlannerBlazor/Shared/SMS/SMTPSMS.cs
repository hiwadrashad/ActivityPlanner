using ActivityPlannerBlazor.Shared.DTOS;
using ActivityPlannerBlazor.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ActivityPlannerBlazor.Shared.SMS
{
    public class SMTPSMS
    {
        public static void SendSMS(AttendeeDTO attendee, AppointmentDTO appointment, OrganizerDTO organizer)
        {
            SmtpClient smtp = new SmtpClient();
            MailMessage message = new MailMessage();
            smtp.Credentials = new System.Net.NetworkCredential("testmailopdracht@gmail.com", "testmail");
            smtp.Host = "ipipi.com";
            message.From = new MailAddress("testmailopdracht@gmail.com");
            message.To.Add(attendee.Data.Email);
            message.Subject = "activity planner invite";
            message.Body = MessageGenerator.ReturnMessage(organizer, appointment);
            smtp.Send(message);
        }
    }
}
