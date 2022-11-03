using Domain;

namespace Application.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string TcNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int ParentPositionId { get; set; }
        public int ManagerId { get; set; }
        public string TelNr { get; set; }
        public float Salary { get; set; }
    }
}
