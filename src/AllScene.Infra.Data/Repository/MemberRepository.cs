using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Infra.Data.Context;
using Dapper;

namespace AllScene.Infra.Data.Repository
{
	public class MemberRepository : Repository<Member>, IMemberRepository
	{
		#region Attributes
		private readonly DbConnection _cn;
		#endregion

		#region Constructor
		public MemberRepository(AllSceneContext context) : base(context)
		{
			_cn = Db.Database.Connection;
		}
		#endregion

		#region Methods
		public Member GetByName(string name)
		{
			return Search(c => c.Name.Equals(name)).FirstOrDefault();
		}

		public Member GetByNickname(string nickname)
		{
			return Search(c => c.Nickname.Equals(nickname)).FirstOrDefault();
		}

		public override IEnumerable<Member> GetAll()
		{
			var sql = @"
SELECT *
  FROM Member
";
			return _cn.Query<Member>(sql);
		}

		public override Member GetById(Guid id)
		{
			var sql = @"
SELECT A.*
  FROM Member A
 WHERE A.MemberId = @MemberId
";
			var member = _cn.Query<Member>(sql, new {MemberId = id}).FirstOrDefault();
			return member;
		}
		#endregion
	}
}
