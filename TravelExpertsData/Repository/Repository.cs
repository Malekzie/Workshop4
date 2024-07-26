using System.Linq.Expressions;

namespace TravelExpertsData.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TravelExpertsContext _context;

        public Repository(TravelExpertsContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> GetNextIdAsync()
        {
            var entityType = typeof(T);
            var idProperty = entityType.GetProperties()
                                       .FirstOrDefault(p => p.Name.EndsWith("Id", StringComparison.OrdinalIgnoreCase));

            if (idProperty == null)
            {
                throw new InvalidOperationException($"No ID property found on type {entityType.Name}");
            }

            // Fetch all entities into memory
            var allEntities = await _context.Set<T>().ToListAsync();

            // Get the maximum ID value
            var maxId = allEntities.Max(e => (int)idProperty.GetValue(e));

            return maxId + 1;
        }

    }
}
