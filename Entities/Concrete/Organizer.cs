﻿using Entities.Abstract;
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
        [Key,ForeignKey(nameof(User))]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public User User { get; set; }

    }
}
