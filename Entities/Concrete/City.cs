using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class City : IEntity
    {

        public City()
        {
            Events = new HashSet<Event>();
        }
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }

        public ICollection<Event> Events { get; set; }

    }
}
