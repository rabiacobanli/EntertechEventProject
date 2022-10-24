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

        public List<Event> GetAll()
        {
            return _eventDal.GetAll();
        }

        public List<Event> GetAllByCategoryId(int categoryid)
        {
            return _eventDal.GetAll(c => c.CategoryId == categoryid);
        }

        public List<Event> GetAllByCityId(int cityid)
        {
            return _eventDal.GetAll(c => c.CityId == cityid);
        }

        public Event GetById(int productId)
        {
            return _eventDal.Get(e => e.EventId == productId);
        }

        

       
    }
}
