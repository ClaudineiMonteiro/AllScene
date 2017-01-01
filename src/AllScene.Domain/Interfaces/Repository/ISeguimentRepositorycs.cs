using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface ISeguimentRepositorycs : IRepository<Seguiment>
	{
		Seguiment GetByDescription(string description);
	}
}
