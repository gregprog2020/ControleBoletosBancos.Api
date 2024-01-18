using ControleBoleto.Core.DomainObjects;
using ControleBoleto.Data;
using ControleBoleto.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly ApiDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(ApiDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public virtual async Task Remover(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}