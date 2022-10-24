using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfOrganizerDal : EfEntityRepositoryBase<Organizer, EventContext>, IOrganizerDal
    {
        
    }
}
