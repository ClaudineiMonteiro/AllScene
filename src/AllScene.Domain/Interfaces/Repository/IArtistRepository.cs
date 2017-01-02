using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface IArtistRepository : IRepository<Artist>
	{
		Artist GetByDescription(string description);
	}
}
