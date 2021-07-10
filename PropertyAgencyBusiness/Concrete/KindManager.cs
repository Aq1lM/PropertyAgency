using System.Collections.Generic;
using PropertyAgency.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;
using PropertyAgencyBusiness.Abstract;

namespace PropertyAgencyBusiness.Concrete
{
    public class KindManager : IKindService
    {
        private IKindDal _kindDal;

        public KindManager(IKindDal kindDal)
        {
            _kindDal = kindDal;
        }
        public void Add(Kind kind)
        {
            _kindDal.Add(kind);
        }

        public void Update(Kind kind)
        {
            _kindDal.Update(kind);
        }

        public void Delete(Kind kind)
        {
            _kindDal.Delete(kind);
        }

        public List<Kind> GetAll()
        {
            return _kindDal.GetAll();
        }

        public Kind GetById(int id)
        {
            return _kindDal.Get(k => k.Id == id);
        }
    }
}
