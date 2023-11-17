using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestingTDP
{
    internal class Correo
    {
        internal static void Email(string EmailUser, string Subject, string Body)
        {
            try
            {
                MailMessage newMail = new MailMessage();
                // use the Gmail SMTP Host
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                // Follow the RFS 5321 Email Standard
                newMail.From = new MailAddress("tdp20034@gmail.com", "JO-NA Panaderia");

                newMail.To.Add(EmailUser);// declare the email subject

                newMail.Subject = Subject; // use HTML for the email body

                newMail.IsBodyHtml = true; newMail.Body = Body;


                // enable SSL for encryption across channels
                client.EnableSsl = true;
                // Port 465 for SSL communication
                client.Port = 587;
                // Provide authentication information with Gmail SMTP server to authenticate your sender account
                client.Credentials = new System.Net.NetworkCredential("tdp20034@gmail.com", "ywxk zlcq vifh udld");

                client.Send(newMail); // Send the constructed mail
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error -" + ex);
            }
        }
}
}
