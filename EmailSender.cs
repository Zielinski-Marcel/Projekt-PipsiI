namespace PoroCounter2;

using Humanizer;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using NuGet.Protocol.Plugins;
using PoroCounter2.ViewModels;
using System.Net;
using System.Net.Mail;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string receiver, string subject, string message)
    {
        var client = new SmtpClient("smtp.outlook.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("PoroCounterSupp@outlook.com", "")//password email
        };

        return client.SendMailAsync(
            new MailMessage(from: "PoroCounterSupp@outlook.com",
                            to: receiver,
                            subject,
                            message
                            ));
    }
    public Task SendEmailToYourself(string receiver)
    {
        var client = new SmtpClient("smtp.outlook.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("PoroCounterSupp@outlook.com", "")//password email
        };

        return client.SendMailAsync(
        new MailMessage(from: "PoroCounterSupp@outlook.com",
                        to: "PoroCounterSupp@outlook.com",
                        "CONTACT US",
                        receiver + " Contacted Us"
                        ));
    }
}