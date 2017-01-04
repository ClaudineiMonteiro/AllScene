using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using DomainValidation.Interfaces.Specification;

namespace AllScene.Domain.Specifications.Seguiments
{
	public class SeguimentUpMustHaveUniqueDescriptionSpecification : ISpecification<Seguiment>
	{
		#region Atributes
		private readonly ISeguimentRepository _seguimentRepository;
		#endregion

		#region Constructors

		public SeguimentUpMustHaveUniqueDescriptionSpecification(ISeguimentRepository seguimentRepository)
		{
			_seguimentRepository = seguimentRepository;
		}
		#endregion

		#region Methods

		public bool IsSatisfiedBy(Seguiment seguiment)
		{
			return _seguimentRepository.GetByDescription(seguiment.Description) == null;
		}
		#endregion
	}
}
