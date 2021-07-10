using System.Collections.Generic;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgencyBusiness.Abstract
{
    public interface IKindService
    {
        void Add(Kind kind);
        void Update(Kind kind);
        void Delete(Kind kind);
        List<Kind> GetAll();
        Kind GetById(int id);
    }
}
