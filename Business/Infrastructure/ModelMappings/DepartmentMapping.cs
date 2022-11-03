using Domain;

namespace Infrastructure.ModelMappings
{
    public class DepartmentMapping : BaseMapping<Department>
    {
        public DepartmentMapping()
        {
            Map(x => x.Name, "Department");
            Table("Department");
        }
    }
}
