using System.Collections.Generic;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgencyBusiness.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        List<Customer> GetAll();
        Customer GetById(int id);
    }
}
