using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Service
{
	public interface IGenreService : IDisposable
	{
		Genre Add(Genre genre);
		Genre GetById(Guid id);
		Genre GetByDescription(string description);
		IEnumerable<Genre> GetAll();
		Genre Update(Genre genre);
		void Remove(Guid id);
	}
}
