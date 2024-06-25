using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Email.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController
    {
        [HttpPost]
        public Task<bool> Send(EmailDto emailDto)
        {
            ArgumentNullException.ThrowIfNull(emailDto);
            return Task.FromResult(true);
        }
    }

    public record EmailDto(string From, string To, string Subject, string Body);
}