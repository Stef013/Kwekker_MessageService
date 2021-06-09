using Message_Consumer.RabbitMQ;
using RabbitMQ.Client;
using System;

namespace Message_Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory
            {
                //Uri = new Uri("amqp://guest:guest@localhost:5672")
                Uri = new Uri("amqps://pyyhgkww:G4oBiRYHjF5NSbPDSDsuZhKleI6ujAbw@kangaroo.rmq.cloudamqp.com/pyyhgkww")
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            QueueConsumer.Consume(channel);
        }
    }
}
