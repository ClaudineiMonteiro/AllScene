using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface IMemberRepository : IRepository<Member>
	{
		Member GetByDescription(string description);
		Member GetByNickname(string nickname);
	}
}
