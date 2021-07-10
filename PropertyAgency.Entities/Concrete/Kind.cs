using Core.Entities.Abstract;

namespace PropertyAgency.Entities.Concrete
{
    public class Kind : IEntity
    {
        public int Id { get; set; }
        public string KindName { get; set; }
    }
}
