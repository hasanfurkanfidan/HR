using Application.SPModels;
using Core.Repository;
using Domain;

namespace Application.Repository
{
    public interface IPositionRepository : IGenericRepository<Position>
    {
        AverageSalaryOfPositionSPModel GetAverageSalaryOfPosition(string position);
    }
}
