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

        public void TAdd(Organizer t)
        {
            _organizerDal.Add(t);
        }

        public void TDelete(Organizer t)
        {
            _organizerDal.Delete(t);
        }

        public void TUpdate(Organizer t)
        {
            _organizerDal.Update(t);
        }

        List<Organizer> IGenericService<Organizer>.TGetAll()
        {
            return _organizerDal.GetAll();
        }

        Organizer IGenericService<Organizer>.TGetByID(int id)
        {
            return _organizerDal.Get(o => o.ID == id);
        }
    }
}
