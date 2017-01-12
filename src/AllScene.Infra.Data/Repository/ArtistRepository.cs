using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Infra.Data.Context;
using Dapper;

namespace AllScene.Infra.Data.Repository
{
	public class ArtistRepository : Repository<Artist>, IArtistRepository
	{
		#region Attributes
		private readonly DbConnection _cn;
		#endregion

		#region Constructors
		public ArtistRepository(AllSceneContext context) : base(context)
		{
			_cn = Db.Database.Connection;
		}
		#endregion

		#region Methods
		public Artist GetByDescription(string description)
		{
			return Search(c => c.Description.Equals(description)).FirstOrDefault();
		}

		public override IEnumerable<Artist> GetAll()
		{
			var sql = @"
SELECT *
  FROM Artist A
";
			return _cn.Query<Artist>(sql);
		}

		public override Artist GetById(Guid id)
		{
			var sql = @"
SELECT *
  FROM Artist A
 WHERE A.ArtistId = @ArtistId

SELECT * 
  FROM Member B
 B.ArtistId = @ArtistId
";
			using (var mult = _cn.QueryMultiple(sql, new { ArtistId = id}))
			{
				var artist = mult.Read<Artist>().Single();
				var members = mult.Read<Member>().ToList();
				foreach (var member in members)
				{
					artist.Members.Add(member);
				}
				return artist;
			}
		}
		#endregion
	}
}
