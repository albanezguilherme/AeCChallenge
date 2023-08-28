using AeCChallenge.Core.Entities;
using AeCChallenge.Core.Interfaces.Repositories;
using AeCChallenge.Core.Interfaces.Services;

namespace AeCChallenge.Core.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Add(T entity)
        {
            _genericRepository.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _genericRepository.GetById(id);
        }
    }
}
