using Message_Producer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Producer.Services.Interfaces
{
    interface IMessageService
    {
        public List<Message> getRecieved(int profileID);
    }
}
