using AllScene.Domain.Entities;
using AllScene.Domain.Specifications.Seguiments;
using DomainValidation.Validation;

namespace AllScene.Domain.Validations.Seguiments
{
	public class SeguimentIsConsistentValidation : Validator<Seguiment>
	{
		#region Constructors

		public SeguimentIsConsistentValidation()
		{
			var seguimentDescription = new SeguimentMustHaveCompletedDescriptionValidoSpecification();
			base.Add("seguimentDescription", new Rule<Seguiment>(seguimentDescription, "Seguimento esta com a descrição vazia"));
		}
		#endregion
	}
}
