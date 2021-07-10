using Core.Entities.Abstract;

namespace PropertyAgency.Entities.Concrete
{
    public class House :IEntity
    {
        public int Id { get; set; }
        public int KindId { get; set; }
        public int CityId { get; set; }
        public string Adress { get; set; }
        public int Rooms { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
    }
}
