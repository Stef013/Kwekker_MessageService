using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading;
using Message_Consumer.Services;
using Message_Consumer.Entities;

namespace Message_Consumer.RabbitMQ
{
    public class QueueConsumer
    {
        public static void Consume(IModel channel)
        {
            MessageService messageService = new MessageService();

            channel.QueueDeclare("message-queue",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) => {
                var body = e.Body.ToArray();
                var messageString = Encoding.UTF8.GetString(body);
                Console.WriteLine(messageString);

                var message = JsonConvert.DeserializeObject<Message>(messageString);

                messageService.saveMessage(message);
            };

            channel.BasicConsume("message-queue", true, consumer);
            Console.WriteLine("Consumer started");
            Console.ReadLine();
        }
    }
}
