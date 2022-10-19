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
    public class EventManager : IEventService
    {
        IEventDal _eventDal;

        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public void TAdd(Event t)
        {
            _eventDal.Add(t);
        }

        public void TDelete(Event t)
        {
            _eventDal.Delete(t);
        }

        public List<Event> TGetAll()
        {
            return _eventDal.GetAll();
        }

        public Event TGetByID(int id)
        {
            return _eventDal.Get(e => e.EventID == id);
        }

        public void TUpdate(Event t)
        {
            _eventDal.Update(t);
        }
    }
}
