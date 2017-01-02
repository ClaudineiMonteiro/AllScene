using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface IGenreRepository : IRepository<Genre>
	{
		Genre GetByDescription(string description);
	}
}
