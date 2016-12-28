using System;
using DomainValidation.Validation;

namespace AllScene.Domain.Entities
{
	public class Genre
	{
		#region Constructor
		public Genre()
		{
			GenreId = Guid.NewGuid();
		}
		#endregion

		#region Properties
		public Guid GenreId { get; set; }
		public string Description { get; set; }
		public Guid ArtistId { get; set; }
		public virtual Artist Artist { get; set; }
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
