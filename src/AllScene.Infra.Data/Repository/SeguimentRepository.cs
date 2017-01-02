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
	public class SeguimentRepository : Repository<Seguiment>, ISeguimentRepository
	{
		private readonly DbConnection _cn;
		public SeguimentRepository(AllSceneContext context) : base(context)
		{
			_cn = Db.Database.Connection;
		}

		public Seguiment GetByDescription(string description)
		{
			return Search(c => c.Description.Equals(description)).FirstOrDefault();
		}

		public override IEnumerable<Seguiment> GetAll()
		{
			var sql = @"
SELECT *
  FROM Sequiment
";
			return _cn.Query<Seguiment>(sql);
		}

		public override Seguiment GetById(Guid id)
		{
			var sql = @"
SELECT A.*
  FROM Seguiment A
 WHERE A.SeguimentId = @SeguimentId
";
			var seguiment = _cn.Query<Seguiment>(sql, new {SeguimentId = id});
			return seguiment.FirstOrDefault();
		}
	}
}
