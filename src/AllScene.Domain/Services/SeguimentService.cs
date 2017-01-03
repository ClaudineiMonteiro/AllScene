using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Service;
using AllScene.Domain.Interfaces.Repository;

namespace AllScene.Domain.Services
{
	public class SeguimentService : ISeguimentService
	{
		#region Attribuites
		private readonly ISeguimentRepository _seguimentRepository;
		#endregion

		#region Constructors

		public SeguimentService(ISeguimentRepository seguimentRepository)
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

		public Seguiment Add(Seguiment seguiment)
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

		public Seguiment GetById(Guid id)
		{
			return _seguimentRepository.GetById(id);
		}

		public Seguiment GetByDescription(string description)
		{
			return _seguimentRepository.GetByDescription(description);
		}

		public IEnumerable<Seguiment> GetAll()
		{
			return _seguimentRepository.GetAll();
		}

		public Seguiment Update(Seguiment seguiment)
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
