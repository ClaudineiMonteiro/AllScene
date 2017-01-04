using AllScene.Domain.Entities;
using DomainValidation.Interfaces.Specification;

namespace AllScene.Domain.Specifications.Seguiments
{
	public class SeguimentMustHaveCompletedDescriptionValidoSpecification : ISpecification<Seguiment>
	{
		#region Methods

		public bool IsSatisfiedBy(Seguiment seguiment)
		{
			return seguiment.Description.Length > 0;
		}
		#endregion
	}
}
