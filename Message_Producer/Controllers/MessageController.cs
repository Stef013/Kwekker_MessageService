using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Message_Producer.Entities;
using Message_Producer.RabbitMQ;
using Message_Producer.DataAccess;
using Message_Producer.Services;

namespace Message_Producer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        QueueProducer producer;
        private readonly ILogger<MessageController> _logger;
        private MessageService messageService;

        public MessageController(MessageDbContext context, ILogger<MessageController> logger)
        {
            messageService = new MessageService(context);
            producer = new QueueProducer();
            _logger = logger;
        }

        [HttpGet]
        public string get ()
        {
            return "Message_Producer";
        }

        [HttpGet("recieved")]
        public List<Message> getProfileId(int profileID)
        {
            return messageService.getRecieved(profileID);
        }

        [HttpPost]
        public void Post([FromBody] Message message)
        {
            producer.Publish(message);
        }
    }
}
