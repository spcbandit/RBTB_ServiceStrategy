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
    public class SettingsRepository : IRepository<SettingsEntity>
    {
        private readonly DbSet<SettingsEntity> _db;
        private readonly RBTB_ServiceStrategyContext _context;

        public SettingsRepository(RBTB_ServiceStrategyContext context)
        {
            _context = context;
            _db = context.Set<SettingsEntity>();
        }
        public int Create(SettingsEntity item)
        {
            _db.Add(item);
            return _context.SaveChanges();
        }

        public SettingsEntity FindById(Guid id)
        {
            return _db.Find(id);
        }

        public IEnumerable<SettingsEntity> Get()
        {
            return _db.AsNoTracking().ToList();
        }

        public IEnumerable<SettingsEntity> Get(Func<SettingsEntity, bool> predicate)
        {
            return _db.AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<SettingsEntity> GetWithInclude(Func<SettingsEntity, bool> predicate, 
            params Expression<Func<SettingsEntity, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        public IQueryable<SettingsEntity> Include(params Expression<Func<SettingsEntity, object>>[] includeProperties)
        {
            IQueryable<SettingsEntity> query = _db.AsNoTracking();
            return includeProperties.Aggregate(query, (current,
                includeProperty) => current.Include(includeProperty));
        }

        public int Remove(SettingsEntity item)
        {
            _db.Remove(item);
            return _context.SaveChanges();
        }

        public int Update(SettingsEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}