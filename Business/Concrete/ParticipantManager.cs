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

        public void TAdd(Participant t)
        {
            _paticipantDal.Add(t);
        }

        public void TDelete(Participant t)
        {
            _paticipantDal.Delete(t);

        }

        public List<Participant> TGetAll()
        {
            return _paticipantDal.GetAll();

        }

        public Participant TGetByID(int id)
        {
            return _paticipantDal.Get(p => p.ID == id);
        }

        public void TUpdate(Participant t)
        {
            _paticipantDal.Update(t);

        }
    }
}
