using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;

namespace AllScene.Domain.Interfaces.Service
{
	public interface IMemberService : IDisposable
	{
		Member Add(Member genre);
		Member GetById(Guid id);
		Member GetByDescription(string description);
		IEnumerable<Member> GetAll();
		Member Update(Member genre);
		void Remove(Guid id);
	}
}
