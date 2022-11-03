using Domain;

namespace Infrastructure.ModelMappings
{
    public class PersonMapping : BaseMapping<Person>
    {
        public PersonMapping()
        {
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Code);
            Map(x => x.Gender);
            Map(x => x.BirthDate);
            Map(x => x.InDate);
            Map(x => x.OutDate);
            Map(x => x.DepartmentId);
            Map(x => x.PositionId);
            Map(x => x.ParentPositionId);
            Map(x => x.ManagerId);
            Map(x => x.TelNr);
            Map(x => x.Salary);
            Map(x => x.TcNumber);
            Table("Person");
        }
    }
}
