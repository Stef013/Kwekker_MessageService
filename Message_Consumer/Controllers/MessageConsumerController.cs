using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Producer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageConsumerController : ControllerBase
    {
        [HttpGet]
        public string get ()
        {
            return "Message_Producer";
        }
    }
}
