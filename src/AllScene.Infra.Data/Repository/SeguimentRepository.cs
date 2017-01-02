using System;
using System.Collections.Generic;
using System.Linq;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Infra.Data.Context;
using Dapper;

namespace AllScene.Infra.Data.Repository
{
	public class SeguimentRepository : Repository<Seguiment>, ISeguimentRepositorycs
	{
		public SeguimentRepository(AllSceneContext context) : base(context)
		{
		}

		public Seguiment GetByDescription(string description)
		{
			return Search(c => c.Description.Equals(description)).FirstOrDefault();
		}

		public override IEnumerable<Seguiment> GetAll()
		{
			var cn = Db.Database.Connection;
			var sql = @"
SELECT *
  FROM Sequiment
";
			return cn.Query<Seguiment>(sql);
		}

		public override Seguiment GetById(Guid id)
		{
			var cn = Db.Database.Connection;
			var sql = @"
SELECT A.*
  FROM Seguiment A
 WHERE A.SeguimentId = @SeguimentId
";
			var seguiment = cn.Query<Seguiment>(sql, new {SeguimentId = id});
			return seguiment.FirstOrDefault();
		}
	}
}
