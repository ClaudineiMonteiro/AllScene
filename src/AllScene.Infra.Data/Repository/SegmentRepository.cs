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
	public class SegmentRepository : Repository<Segment>, ISegmentRepository
	{
		private readonly DbConnection _cn;
		public SegmentRepository(AllSceneContext context) : base(context)
		{
			_cn = Db.Database.Connection;
		}

		public Segment GetByDescription(string description)
		{
			return Search(c => c.Description.Equals(description)).FirstOrDefault();
		}

		public override IEnumerable<Segment> GetAll()
		{
			var sql = @"
SELECT *
  FROM Seqment
";
			return _cn.Query<Segment>(sql);
		}

		public override Segment GetById(Guid id)
		{
			var sql = @"
SELECT A.*
  FROM Segment A
 WHERE A.SegmentId = @SegmentId
";
			var segment = _cn.Query<Segment>(sql, new {SegmentId = id});
			return segment.FirstOrDefault();
		}
	}
}
