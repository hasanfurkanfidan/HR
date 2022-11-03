using Application.Repository;
using Application.SPModels;
using Core.Repository.NHibernate;
using Domain;
using NHibernate;
using NHibernate.Transform;

namespace Infrastructure.Repositories
{
    public class PositionRepository : NhibernateGenericRepository<Position>, IPositionRepository
    {
        private readonly ISession _session;
        public PositionRepository(ISession session) : base(session)
        {
            _session = session;
        }

        public AverageSalaryOfPositionSPModel GetAverageSalaryOfPosition(string position)
        {
            var query = _session.CreateSQLQuery("EXEC SP_FINDAVGSALARYOFSELECTEDPOSITION @Position=:Position").SetResultTransformer(Transformers.AliasToBean<AverageSalaryOfPositionSPModel>());
            query.SetString("Position", position);
            return query.UniqueResult<AverageSalaryOfPositionSPModel>();
        }
    }
}
