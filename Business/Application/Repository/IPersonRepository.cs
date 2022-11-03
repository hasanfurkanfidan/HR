using Application.SPModels;
using Core.Repository;
using Domain;

namespace Application.Repository
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        List<PersonWorkingTimeSPModel> GetPersonWorkingTimes();
        List<FemaleMalePersonsInDateStatisticsSPModel> GetFemaleMaleInDateStatistics();
    }
}
