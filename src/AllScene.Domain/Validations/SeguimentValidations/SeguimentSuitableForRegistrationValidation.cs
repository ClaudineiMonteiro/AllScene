using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Domain.Specifications.Seguiments;
using DomainValidation.Validation;

namespace AllScene.Domain.Validations.SeguimentValidations
{
	public class SeguimentSuitableForRegistrationValidation : Validator<Seguiment>
	{
		public SeguimentSuitableForRegistrationValidation(ISeguimentRepository seguimentRepository)
		{
			var duplicateDescription = new SeguimentUpMustHaveUniqueDescriptionSpecification(seguimentRepository);
			base.Add("duplicateDescription", new Rule<Seguiment>(duplicateDescription, "Descrição já cadastrada!"));
		}
	}
}
