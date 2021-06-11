using Message_Producer.DataAccess;
using Message_Producer.Entities;
using Message_Producer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Producer.Services
{
    public class MessageService : IMessageService
    {
        private readonly MessageDbContext _context;

        public MessageService(MessageDbContext context)
        {
            _context = context;
        }

        public List<Message> getRecieved(int profileID)
        {
            List<Message> messages;
            try
            {
                messages = _context.Message.Where(p => p.recieverID == profileID).ToList();

                return messages;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                messages = new List<Message>();
                return messages;
            }
        }
    }
}
