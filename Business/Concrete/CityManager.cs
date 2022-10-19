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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void TAdd(City t)
        {
            _cityDal.Add(t);
        }

        public void TDelete(City t)
        {
            _cityDal.Delete(t);
        }

        public List<City> TGetAll()
        {
            return _cityDal.GetAll();
        }

        public City TGetByID(int id)
        {
            return _cityDal.Get(c => c.CityID == id);
        }

        public void TUpdate(City t)
        {
            _cityDal.Update(t);
        }
    }
}
