using System;
using DomainValidation.Validation;

namespace AllScene.Application.ViewModels
{
	public class SegmentViewModel
	{
		#region Constructors

		public SegmentViewModel()
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
	}
}