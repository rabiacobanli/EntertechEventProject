using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrganizerManager : IOrganizerService
    {
        IOrganizerDal _organizerDal;

        public OrganizerManager(IOrganizerDal organizerDal)
        {
            _organizerDal = organizerDal;
        }

        
    }
}
