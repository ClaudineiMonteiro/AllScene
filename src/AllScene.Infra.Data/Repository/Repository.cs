using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Infra.Data.Context;

namespace AllScene.Infra.Data.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		#region Attributes
		protected AllSceneContext Db;
		protected DbSet<TEntity> DbSet;
		#endregion

		#region Constructor
		public Repository(AllSceneContext context)
		{
			Db = context;
			DbSet = Db.Set<TEntity>();
		}
		#endregion

		#region Methods
		public virtual TEntity Add(TEntity obj)
		{
			var objectReturn = DbSet.Add(obj);
			return objectReturn;
		}

		public virtual TEntity GetById(Guid id)
		{
			return DbSet.Find(id);
		}

		public virtual IEnumerable<TEntity> GetAll()
		{
			return DbSet.ToList();
		}

		public virtual TEntity Update(TEntity obj)
		{
			var entry = Db.Entry(obj);
			DbSet.Attach(obj);
			entry.State = EntityState.Modified;
			return obj;
		}

		public virtual void Remover(Guid id)
		{
			DbSet.Remove(DbSet.Find(id));
		}

		public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Where(predicate);
		}

		public int SaveChange()
		{
			return Db.SaveChanges();
		}

		public void Dispose()
		{
			Db.Dispose();
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
