﻿using Core.DataAccess.Concrete.EntityFramework;
using PropertyAgency.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgency.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer,PropertyAgencyContext>, ICustomerDal
    {
    }
}
