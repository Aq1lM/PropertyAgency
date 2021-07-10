using Core.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgency.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
