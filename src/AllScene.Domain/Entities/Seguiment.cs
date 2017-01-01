using System;
using DomainValidation.Validation;

namespace AllScene.Domain.Entities
{
	public class Seguiment
	{
		#region Constructors

		public Seguiment()
		{
			SeguimentId = Guid.NewGuid();
		}
		#endregion

		#region Properties

		public Guid SeguimentId { get; set; }
		public string Description { get; set; }
		public DateTime RegistrationDate { get; set; }
		public DateTime DateLastModfield { get; set; }
		public ValidationResult ValidationResult { get; set; }
		#endregion

		#region Methods

		public bool IsValid()
		{
			//Include business rules
			return true;
		}
		#endregion
	}
}
