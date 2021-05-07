using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Message_Consumer.Entities;

namespace Message_Consumer.DataAccess
{
    public class MessageDbContext : DbContext
    {
        public DbSet<Message> Message { get; set; }

        //public MessageDbContext(DbContextOptions<MessageDbContext> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string mySqlConnectionStr = "server=localhost; port=3306; database=Kwekker_message; user=root; password=Pudace007; Persist Security Info=False; Connect Timeout=300";
            optionsBuilder.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
        }
    }
}
