using Core.Models;

namespace Domain
{
    public class Position : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
