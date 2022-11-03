using Core.Models;
using FluentNHibernate.Mapping;

namespace Infrastructure.ModelMappings
{
    public class BaseMapping<T> : ClassMap<T> where T : class, IEntity, new()
    {
        public BaseMapping()
        {
            Id(x => x.Id);
        }
    }
}
