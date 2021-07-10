using System.Collections.Generic;
using PropertyAgency.Entities.Concrete;

namespace PropertyAgencyBusiness.Abstract
{
    public interface IHouseService
    {
        void Add(House house);
        void Update(House house);
        void Delete(House house);
        List<House> GetAll();
        House GetById(int id);
        List<House> GetByAdress(string adress);
        List<House> GetByKind(int kindId);
        List<House> GetByCity(int cityId);
        List<House> GetByCustomer(int customerId);
        List<House> GetByArea(double min, double max);
        double GetMinArea();
        double GetMaxArea();
        List<House> GetByFloor(double min, double max);
        double GetMinFloor();
        double GetMaxFloor();
        List<House> GetByRooms(double min, double max);
        double GetMinRooms();
        double GetMaxRooms();
        List<House> GetByPrice(decimal min, decimal max);
        decimal GetMinPrice();
        decimal GetMaxPrice();
    }
}
