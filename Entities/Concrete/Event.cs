﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Event:IEntity
    {
        public Event()
        {
            Users = new HashSet<User>();
        }
      
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public string Address { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }
        public int EventQuota { get; set; }
        public string Description { get; set; }
        public bool IsItTicketed { get; set; }
        public decimal? TicketPrice { get; set; }

        public Category Category { get; set; }
        public City City { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
