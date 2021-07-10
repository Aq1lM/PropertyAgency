using System.Collections.Generic;
using PropertyAgency.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;
using PropertyAgencyBusiness.Abstract;

namespace PropertyAgencyBusiness.Concrete
{
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public void Add(City city)
        {
            _cityDal.Add(city);
        }

        public void Update(City city)
        {
            _cityDal.Update(city);
        }

        public void Delete(City city)
        {
            _cityDal.Delete(city);
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public City GetById(int id)
        {
            return _cityDal.Get(c=>c.Id==id);
        }
    }
}
