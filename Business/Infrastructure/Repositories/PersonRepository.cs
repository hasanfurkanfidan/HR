using Application.Repository;
using Application.SPModels;
using Core.Repository.NHibernate;
using Domain;
using NHibernate;
using NHibernate.Transform;

namespace Infrastructure.Repositories
{
    public class PersonRepository : NhibernateGenericRepository<Person>, IPersonRepository
    {
        private readonly ISession _session;
        public PersonRepository(ISession session) : base(session)
        {
            _session = session;
        }

        public List<FemaleMalePersonsInDateStatisticsSPModel> GetFemaleMaleInDateStatistics()
        {
            var query = _session.CreateSQLQuery("EXEC SP_MALEANDFEMALEPERSONBYINDATE").SetResultTransformer(Transformers.AliasToBean<FemaleMalePersonsInDateStatisticsSPModel>());
            return query.List<FemaleMalePersonsInDateStatisticsSPModel>().ToList();
        }

        public List<PersonWorkingTimeSPModel> GetPersonWorkingTimes()
        {
            var query = _session.CreateSQLQuery("EXEC SP_PERSONWORKINGTIME").SetResultTransformer(Transformers.AliasToBean<PersonWorkingTimeSPModel>());
            return query.List<PersonWorkingTimeSPModel>().ToList();
        }
    }
}
