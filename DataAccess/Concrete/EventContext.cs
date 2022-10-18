using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public  class EventContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EventManagementSystem;Trusted_Connection=true");
        }


        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Organizer> Organizers { get; set; }
    }
}
