using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Domain.Specifications.Segments;
using DomainValidation.Validation;

namespace AllScene.Domain.Validations.Segments
{
	public class SegmentSuitableForRegistrationValidation : Validator<Segment>
	{
		public SegmentSuitableForRegistrationValidation(ISegmentRepository segmentRepository)
		{
			var duplicateDescription = new SegmentUpMustHaveUniqueDescriptionSpecification(segmentRepository);
			base.Add("duplicateDescription", new Rule<Segment>(duplicateDescription, "Descrição já cadastrada!"));
		}
	}
}
