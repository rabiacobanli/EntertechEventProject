using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Organizer : IEntity
    {
        //[Key,ForeignKey(nameof(User))]
        public int OrganizerId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }

        //public User User { get; set; }

    }
}
