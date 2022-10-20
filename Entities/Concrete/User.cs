using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public User()
        {
            Events=new HashSet<Event>();
        }
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Participant Participant { get; set; }
        public Organizer Organizer { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
