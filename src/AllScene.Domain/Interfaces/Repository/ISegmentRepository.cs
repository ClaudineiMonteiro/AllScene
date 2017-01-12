using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface ISegmentRepository : IRepository<Segment>
	{
		Segment GetByDescription(string description);
	}
}
