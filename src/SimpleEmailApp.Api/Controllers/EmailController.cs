using Microsoft.AspNetCore.Mvc;
using SimpleEmailApp.Api.Models;
using SimpleEmailApp.Api.Services.EmailService;

namespace SimpleEmailApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : Controller
{
    private readonly IEmailService _emailService;
    
    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }
    
    [HttpPost]
    public IActionResult SendEmail(EmailDto request)
    { 
        _emailService.SendEmail(request);
        
        return Ok();
    }
}