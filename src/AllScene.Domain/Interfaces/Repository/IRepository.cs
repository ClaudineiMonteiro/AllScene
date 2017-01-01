using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface IRepository<TEntity> : IDisposable where TEntity : class
	{
		TEntity Add(TEntity obj);
		TEntity GetById(Guid id);
		IEnumerable<TEntity> GetAll();
		TEntity Update(TEntity obj);
		void Remover(Guid id);
		IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
		int SaveChange();
	}
}
