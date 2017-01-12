using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Service;
using AllScene.Domain.Interfaces.Repository;

namespace AllScene.Domain.Services
{
	public class SegmentService : ISegmentService
	{
		#region Attribuites
		private readonly ISegmentRepository _seguimentRepository;
		#endregion

		#region Constructors

		public SegmentService(ISegmentRepository seguimentRepository)
		{
			_seguimentRepository = seguimentRepository;
		}
		#endregion

		#region Methods
		public void Dispose()
		{
			_seguimentRepository.Dispose();
			GC.SuppressFinalize(this);
		}

		public Segment Add(Segment seguiment)
		{
			if (!seguiment.IsValid())
			{
				return seguiment;
			}
			//seguiment.ValidationResult = 

			if (!seguiment.ValidationResult.IsValid)
			{
				return seguiment;
			}
			seguiment.ValidationResult.Message = "Successfully registered Seguiment :)";
			return _seguimentRepository.Add(seguiment);
		}

		public Segment GetById(Guid id)
		{
			return _seguimentRepository.GetById(id);
		}

		public Segment GetByDescription(string description)
		{
			return _seguimentRepository.GetByDescription(description);
		}

		public IEnumerable<Segment> GetAll()
		{
			return _seguimentRepository.GetAll();
		}

		public Segment Update(Segment seguiment)
		{
			return _seguimentRepository.Update(seguiment);
		}

		public void Remove(Guid id)
		{
			_seguimentRepository.Remove(id);
		}
		#endregion
	}
}
