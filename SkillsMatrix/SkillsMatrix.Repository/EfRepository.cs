using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SkillsMatrix.Repository
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<T> dbSet;

        public EfRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var record = dbSet.Find(id);
            if (record != null)
            {
                dbSet.Remove(record);
                dbContext.SaveChanges();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var record = await dbSet.FindAsync(id);
            if (record != null)
            {
                dbSet.Remove(record);
                await dbContext.SaveChangesAsync();
            }
            
        }

        public T Get(int id) => dbSet.Find(id);

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(int id) => await dbSet.FindAsync(id);

        public void Update(T entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
