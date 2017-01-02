using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface ISeguimentRepository : IRepository<Seguiment>
	{
		Seguiment GetByDescription(string description);
	}
}
