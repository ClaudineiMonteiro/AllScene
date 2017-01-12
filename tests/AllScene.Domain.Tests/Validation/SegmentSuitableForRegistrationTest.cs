using System;
using System.Collections.Generic;
using System.Linq;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Domain.Validations.Segments;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace AllScene.Domain.Tests.Validation
{
	[TestClass]
	public class SegmentSuitableForRegistrationTest
	{
		public Segment Segment { get; set; }

		[TestMethod]
		public void SegmentAble_Validation_True()
		{
			Segment = new Segment()
			{
				Description = "Descrição",
				RegistrationDate = DateTime.Now
			};
			var stubRepo = MockRepository.GenerateStub<ISegmentRepository>();
			stubRepo.Stub(c => c.GetByDescription(Segment.Description)).Return(null);

			var segmentValidation = new SegmentSuitableForRegistrationValidation(stubRepo);
			Assert.IsTrue(segmentValidation.Validate(Segment).IsValid);
		}

		[TestMethod]
		public void SegmentAble_Validation_False()
		{
			Segment = new Segment()
			{
				Description = "Descrição",
				RegistrationDate = DateTime.Now
			};
			var stubRepo = MockRepository.GenerateStub<ISegmentRepository>();
			stubRepo.Stub(c => c.GetByDescription(Segment.Description)).Return(Segment);

			var segmentValidation = new SegmentSuitableForRegistrationValidation(stubRepo);
			var result = segmentValidation.Validate(Segment);

			Assert.IsFalse(segmentValidation.Validate(Segment).IsValid);
			Assert.IsTrue(result.Erros.Any(e => e.Message.Equals("Descrição já cadastrada!")));
		}
	}
}
