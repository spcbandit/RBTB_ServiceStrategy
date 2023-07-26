using Microsoft.EntityFrameworkCore;
using RBTB_ServiceStrategy.Application.Abstractions;
using RBTB_ServiceStrategy.Application.Entities;
using RBTB_ServiceStrategy.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RBTB_ServiceStrategy.Database.Repository
{
    public class StrategyRepository : IRepository<StrategyEntity>
    {
        private readonly DbSet<StrategyEntity> _db;
        private readonly RBTB_ServiceStrategyContext _context;

        public StrategyRepository(RBTB_ServiceStrategyContext context)
        {
            _context = context;
            _db = context.Set<StrategyEntity>();

        }

        public int Create(StrategyEntity item)
        {
            _db.Add(item);
            return _context.SaveChanges();
        }

        public StrategyEntity FindById(Guid id)
        {
            return _db.Find(id);
        }

        public IEnumerable<StrategyEntity> Get()
        {
            return _db.AsNoTracking().ToList();
        }

        public IEnumerable<StrategyEntity> Get(Func<StrategyEntity, bool> predicate)
        {
            return _db.AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<StrategyEntity> GetWithInclude(Func<StrategyEntity, bool> predicate, params Expression<Func<StrategyEntity, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        public IQueryable<StrategyEntity> Include(params Expression<Func<StrategyEntity, object>>[] includeProperties)
        {
            IQueryable<StrategyEntity> query = _db.AsNoTracking();
            return includeProperties.Aggregate(query, (current, 
                includeProperty) => current.Include(includeProperty));
        }

        public int Remove(StrategyEntity item)
        {
            _db.Remove(item);
            return _context.SaveChanges();
        }

        public int Update(StrategyEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
