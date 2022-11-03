using Core.Models;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace Domain
{
    public class Person : IEntity
    {
        public virtual int Id { get ; set ; }
        public virtual string Code { get; set; }
        public virtual string TcNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual DateTime InDate { get; set; }
        public virtual DateTime? OutDate { get; set; }
        public virtual int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public virtual int ParentPositionId { get; set; }
        public virtual Position ParentPosition { get; set; }
        public virtual int ManagerId { get; set; }
        public virtual Person Manager { get; set; }
        public virtual string TelNr { get; set; }
        public virtual float Salary { get; set; }
    }
}
