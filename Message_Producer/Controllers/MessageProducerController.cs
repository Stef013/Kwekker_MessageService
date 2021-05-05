using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Message_Producer.Models;
using Message_Producer.RabbitMQ;

namespace Message_Producer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageProducerController : ControllerBase
    {
        QueueProducer producer;

        public MessageProducerController()
        {
            producer = new QueueProducer();
        }

        [HttpGet]
        public string get ()
        {
            return "Message_Producer";
        }

        [HttpPost]
        public void Post([FromBody] Message message)
        {
            producer.Publish(message);
        }
    }
}
