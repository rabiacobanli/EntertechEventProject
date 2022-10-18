﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Organizer
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }

    }
}
