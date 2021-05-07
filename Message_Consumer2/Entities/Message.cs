using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Consumer.Entities
{
    public class Message
    {
        public int ID { get; set; }
        public int senderID { get; set; }
        public int recieverID { get; set; }
        public string message { get; set; }
        public DateTime dateTime { get; set; }
    }
}
