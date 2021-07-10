using System.Collections.Generic;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgencyBusiness.Abstract
{
    public interface ICityService
    {
        void Add(City city);
        void Update(City city);
        void Delete(City city);
        List<City> GetAll();
        City GetById(int id);
    }
}
