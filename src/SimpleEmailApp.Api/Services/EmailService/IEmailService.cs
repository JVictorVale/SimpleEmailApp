using SimpleEmailApp.Api.Models;

namespace SimpleEmailApp.Api.Services.EmailService;

public interface IEmailService
{
    void SendEmail(EmailDto request);
}