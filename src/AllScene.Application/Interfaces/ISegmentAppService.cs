using System;
using System.Collections.Generic;
using AllScene.Application.ViewModels;

namespace AllScene.Application.Interfaces
{
	public interface ISegmentAppService : IDisposable
	{
		SegmentViewModel Add(SegmentViewModel segmentViewModel);
		SegmentViewModel GetById(Guid id);
		SegmentViewModel GetByDescription(string description);
		IEnumerable<SegmentViewModel> GetAll();
		SegmentViewModel Update(SegmentViewModel segmentViewModel);
		void Remove(Guid id);
	}
}