using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GmailApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailSearchController : ControllerBase
    {

        private readonly ILogger<EmailSearchController> _logger;

        public EmailSearchController(ILogger<EmailSearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            return 1;
        }
    }
}
