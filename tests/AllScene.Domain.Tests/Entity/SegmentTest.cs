using System;
using System.Linq;
using AllScene.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllScene.Domain.Tests.Entity
{
	[TestClass]
	public class SegmentTest
	{
		public Segment Segment { get; set; }

		[TestMethod]
		public void SegmentConsistent_Valid_True()
		{
			Segment = new Segment()
			{
				Description = "Segment Description"
			};
			Assert.IsTrue(Segment.IsValid());
		}

		[TestMethod]
		public void SegmentConsistent_Valid_False()
		{
			Segment = new Segment()
			{
				Description = string.Empty
			};

			Assert.IsFalse(Segment.IsValid());
			Assert.IsTrue(Segment.ValidationResult.Erros.Any(e => e.Message.Equals("Segmento esta com a descrição vazia")));
		}
	}
}
