using Application.Repository;
using Core.Repository.NHibernate;
using Domain;
using NHibernate;

namespace Infrastructure.Repositories
{
    public class DepartmentRepository : NhibernateGenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(ISession session) : base(session)
        {

        }
    }
}
