using System.Collections.Generic;
using System.Linq;
using PropertyAgency.DataAccess.Abstract;
using PropertyAgency.Entities.Concrete;
using PropertyAgencyBusiness.Abstract;

namespace PropertyAgencyBusiness.Concrete
{
    public class HouseManager : IHouseService
    {
        private IHouseDal _houseDal;

        public HouseManager(IHouseDal houseDal)
        {
            _houseDal = houseDal;
        }
        public void Add(House house)
        {
            _houseDal.Add(house);
        }

        public void Update(House house)
        {
            _houseDal.Update(house);
        }

        public void Delete(House house)
        {
            _houseDal.Delete(house);
        }

        public List<House> GetAll()
        {
            return _houseDal.GetAll();
        }

        public House GetById(int id)
        {
            return _houseDal.Get(h => h.Id == id);
        }

        public List<House> GetByAdress(string adress)
        {
            return _houseDal.GetAll(h => h.Adress.ToLower().Contains(adress.ToLower()));
        }

        public List<House> GetByKind(int kindId)
        {
            return _houseDal.GetAll(h => h.KindId == kindId);
        }

        public List<House> GetByCity(int cityId)
        {
            return _houseDal.GetAll(h => h.CityId == cityId);
        }

        public List<House> GetByCustomer(int customerId)
        {
            return _houseDal.GetAll(h => h.CustomerId == customerId);
        }

        public List<House> GetByArea(double min, double max)
        {
            return _houseDal.GetAll(h => h.Area >= min && h.Area <= max);
        }

        public List<House> GetByFloor(double min, double max)
        {
            return _houseDal.GetAll(h => h.Floor >= min && h.Floor <= max);
        }

        public List<House> GetByRooms(double min, double max)
        {
            return _houseDal.GetAll(h => h.Rooms >= min && h.Rooms <= max);
        }

        public List<House> GetByPrice(decimal min, decimal max)
        {
            return _houseDal.GetAll(h => h.Price >= min && h.Price <= max);
        }
        public double GetMinArea()
        {
            return _houseDal.GetAll().Select(h => h.Area).Min();
        }
        public double GetMaxArea()
        {
            return _houseDal.GetAll().Select(h => h.Area).Max();
        }
        public double GetMinFloor()
        {
            return _houseDal.GetAll().Select(h => h.Floor).Min();
        }
        public double GetMaxFloor()
        {
            return _houseDal.GetAll().Select(h => h.Floor).Max();
        }

        public double GetMinRooms()
        {
            return _houseDal.GetAll().Select(h => h.Rooms).Min();
        }

        public double GetMaxRooms()
        {
            return _houseDal.GetAll().Select(h => h.Rooms).Min();
        }

        public decimal GetMinPrice()
        {
            return _houseDal.GetAll().Select(h => h.Price).Min();
        }
        public decimal GetMaxPrice()
        {
            return _houseDal.GetAll().Select(h => h.Price).Max();
        }
    }
}
