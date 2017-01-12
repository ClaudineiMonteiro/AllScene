using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using DomainValidation.Interfaces.Specification;

namespace AllScene.Domain.Specifications.Segments
{
	public class SegmentUpMustHaveUniqueDescriptionSpecification : ISpecification<Segment>
	{
		#region Atributes
		private readonly ISegmentRepository _segmentRepository;
		#endregion

		#region Constructors

		public SegmentUpMustHaveUniqueDescriptionSpecification(ISegmentRepository segmentRepository)
		{
			_segmentRepository = segmentRepository;
		}
		#endregion

		#region Methods

		public bool IsSatisfiedBy(Segment segment)
		{
			return _segmentRepository.GetByDescription(segment.Description) == null;
		}
		#endregion
	}
}
