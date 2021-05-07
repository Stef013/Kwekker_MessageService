using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Message_Consumer.Entities;

namespace Message_Consumer.Services.Interfaces
{
    interface IMessageService
    {
        public void saveMessage(Message message);
    }
}
