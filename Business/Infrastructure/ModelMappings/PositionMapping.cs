using Domain;

namespace Infrastructure.ModelMappings
{
    public class PositionMapping : BaseMapping<Position>
    {
        public PositionMapping()
        {
            Map(x => x.Name, "Position");
            Table("Position");
        }
    }
}
