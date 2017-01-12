using AllScene.Domain.Entities;
using AllScene.Domain.Specifications.Segments;
using DomainValidation.Validation;

namespace AllScene.Domain.Validations.Segments
{
	public class SegmentIsConsistentValidation : Validator<Segment>
	{
		#region Constructors

		public SegmentIsConsistentValidation()
		{
			var segmentDescription = new SegmentMustHaveCompletedDescriptionValidoSpecification();
			base.Add("segmentDescription", new Rule<Segment>(segmentDescription, "Segmento esta com a descrição vazia"));
		}
		#endregion
	}
}
