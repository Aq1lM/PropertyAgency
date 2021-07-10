using System.Collections.Generic;
using PropertyAgency.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;
using PropertyAgencyBusiness.Abstract;

namespace PropertyAgencyBusiness.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(c => c.Id == id);
        }
    }
}
