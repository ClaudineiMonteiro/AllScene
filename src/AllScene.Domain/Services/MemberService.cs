using System;
using System.Collections.Generic;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Domain.Interfaces.Service;

namespace AllScene.Domain.Services
{
	public class MemberService : IMemberService
	{
		#region Attrubes
		private readonly IMemberRepository _memberRepository;
		#endregion

		#region
		public MemberService(IMemberRepository memberRepository)
		{
			_memberRepository = memberRepository;
		}
		#endregion

		#region Methods
		public void Dispose()
		{
			_memberRepository.Dispose();
			GC.SuppressFinalize(this);
		}

		public Member Add(Member genre)
		{
			return _memberRepository.Add(genre);
		}

		public Member GetById(Guid id)
		{
			return _memberRepository.GetById(id);
		}

		public Member GetByDescription(string description)
		{
			return GetByDescription(description);
		}

		public IEnumerable<Member> GetAll()
		{
			return _memberRepository.GetAll();
		}

		public Member Update(Member genre)
		{
			return _memberRepository.Update(genre);
		}

		public void Remove(Guid id)
		{
			_memberRepository.Remove(id);
		}
		#endregion
	}
}
