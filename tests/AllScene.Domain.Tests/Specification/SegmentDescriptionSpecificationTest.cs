using AllScene.Domain.Entities;
using AllScene.Domain.Specifications.Segments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllScene.Domain.Tests.Specification
{
	[TestClass]
	public class SegmentDescriptionSpecificationTest
	{
		public Segment Segment { get; set; }

		[TestMethod]
		public void Description_Valid_True()
		{
			Segment = new Segment()
			{
				Description = "Descrição não esta vazia"
			};
			var description = new SegmentMustHaveCompletedDescriptionValidoSpecification();
			Assert.IsTrue(description.IsSatisfiedBy(Segment));
		}

		[TestMethod]
		public void Description_Valid_False()
		{
			Segment = new Segment()
			{
				Description = string.Empty
			};
			var description = new SegmentMustHaveCompletedDescriptionValidoSpecification();
			Assert.IsFalse(description.IsSatisfiedBy(Segment));
		}
	}
}
