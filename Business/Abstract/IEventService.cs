using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEventService
    {
        List<Event> GetAllByCategoryId(int categoryid);
        List<Event> GetAllByCityId(int cityid);
        List<Event> GetAll();
        Event GetById(int productId);
       
      
        
    }
}
