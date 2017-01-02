using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Infra.Data.Context;
using Dapper;

namespace AllScene.Infra.Data.Repository
{
	public class GenreRepository : Repository<Genre>, IGenreRepository
	{
		private readonly DbConnection _cn;
		public GenreRepository(AllSceneContext context) : base(context)
		{
			_cn = Db.Database.Connection;
		}

		public Genre GetByDescription(string description)
		{
			return Search(c => c.Description.Equals(description)).FirstOrDefault();
		}

		public override IEnumerable<Genre> GetAll()
		{
			var sql = @"
SELECT *
  FROM Genre
";
			return _cn.Query<Genre>(sql);
		}

		public override Genre GetById(Guid id)
		{
			var sql = @"
SELECT A.*
  FROM Genre A
 WHERE A.GenreId = @GenreId
";
			var genre = _cn.Query<Genre>(sql, new {GenreId = id}).FirstOrDefault();
			return genre;
		}
	}
}
