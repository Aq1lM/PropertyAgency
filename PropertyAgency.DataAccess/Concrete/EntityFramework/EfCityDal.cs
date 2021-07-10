using Core.DataAccess.Concrete.EntityFramework;
using PropertyAgency.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgency.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal: EfEntityRepositoryBase<City,PropertyAgencyContext>,ICityDal
    {
    }
}
