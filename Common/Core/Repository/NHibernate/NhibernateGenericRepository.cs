using Core.Models;
using NHibernate;

namespace Core.Repository.NHibernate
{
    public class NhibernateGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly ISession _session;
        public NhibernateGenericRepository(ISession session)
        {
            _session = session;
        }
        public void Add(TEntity entity)
        {
            _session.Save(entity);
        }

        public void Delete(TEntity entity)
        {
            _session.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _session.Query<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _session.Query<TEntity>().Where(p => p.Id == id).FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            _session.Update(entity);
        }
    }
}
