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
            string connectionStr = "Server=tcp:kwekker-dbserver.database.windows.net,1433;Initial Catalog=Kwekker_Message;Persist Security Info=False;User ID=KwekkerAdmin;Password=6LqnuWWWVbV58He;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connectionStr);
        }
    }
}
