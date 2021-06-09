using Message_Consumer.DataAccess;
using Message_Consumer.Entities;
using Message_Consumer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Consumer.Services
{
    public class MessageService : IMessageService
    {
        private readonly MessageDbContext _context;
        public MessageService()
        {
            _context = new MessageDbContext();
        }

        public void saveMessage(Message message)
        {
            try
            {
                _context.Message.Add(message);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
