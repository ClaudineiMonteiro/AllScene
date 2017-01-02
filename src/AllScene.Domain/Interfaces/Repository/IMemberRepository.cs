using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Repository
{
	public interface IMemberRepository : IRepository<Member>
	{
		Member GetByName(string name);
		Member GetByNickname(string nickname);
	}
}
