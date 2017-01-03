using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Service
{
	public interface ISeguimentService : IDisposable
	{
		Seguiment Add(Seguiment seguiment);
		Seguiment GetById(Guid id);
		Seguiment GetByDescription(string description);
		IEnumerable<Seguiment> GetAll();
		Seguiment Update(Seguiment seguiment);
		void Remove(Guid id);
	}
}
