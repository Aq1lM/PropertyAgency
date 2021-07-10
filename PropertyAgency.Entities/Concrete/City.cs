using Core.Entities.Abstract;

namespace PropertyAgency.Entities.Concrete
{
    public class City: IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
    }
}
