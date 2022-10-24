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
    public class ParticipantManager : IParticipantService
    {
        IParticipantDal _paticipantDal;

        public ParticipantManager(IParticipantDal paticipantDal)
        {
            _paticipantDal = paticipantDal;
        }

       
    }
}
