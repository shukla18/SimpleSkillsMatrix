using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        Task<T> GetAsync(int id);

        void Delete(int id);

        Task DeleteAsync(int id);

        void Add(T entity);

        Task AddAsync(T entity);

        void Update(T entity);

        Task UpdateAsync(T entity);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();
    }
}
