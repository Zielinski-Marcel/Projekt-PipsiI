using PoroCounter2.ViewModels;

namespace PoroCounter2
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendEmailToYourself(string email);
    }
}
