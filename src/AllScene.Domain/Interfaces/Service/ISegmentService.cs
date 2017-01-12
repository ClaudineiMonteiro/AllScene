using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Service
{
	public interface ISegmentService : IDisposable
	{
		Segment Add(Segment seguiment);
		Segment GetById(Guid id);
		Segment GetByDescription(string description);
		IEnumerable<Segment> GetAll();
		Segment Update(Segment seguiment);
		void Remove(Guid id);
	}
}
