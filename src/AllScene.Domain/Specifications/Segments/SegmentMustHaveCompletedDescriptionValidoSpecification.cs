using AllScene.Domain.Entities;
using DomainValidation.Interfaces.Specification;

namespace AllScene.Domain.Specifications.Segments
{
	public class SegmentMustHaveCompletedDescriptionValidoSpecification : ISpecification<Segment>
	{
		#region Methods

		public bool IsSatisfiedBy(Segment segment)
		{
			return segment.Description.Length > 0;
		}
		#endregion
	}
}
