using System;
using AllScene.Domain.Validations.Segments;
using DomainValidation.Validation;

namespace AllScene.Domain.Entities
{
	public class Segment
	{
		#region Constructors

		public Segment()
		{
			SegmentId = Guid.NewGuid();
		}
		#endregion

		#region Properties

		public Guid SegmentId { get; set; }
		public string Description { get; set; }
		public DateTime RegistrationDate { get; set; }
		public DateTime DateLastModified { get; set; }
		public ValidationResult ValidationResult { get; set; }
		#endregion

		#region Methods

		public bool IsValid()
		{
			ValidationResult = new SegmentIsConsistentValidation().Validate(this);
			return ValidationResult.IsValid;
		}
		#endregion
	}
}
