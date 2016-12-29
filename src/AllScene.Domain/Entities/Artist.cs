using System;
using System.Collections.Generic;
using DomainValidation.Validation;

namespace AllScene.Domain.Entities
{
	public class Artist
	{
		#region Constructors

		public Artist()
		{
			ArtistId = Guid.NewGuid();
			Members = new List<Member>();
		}
		#endregion

		#region Properties

		public Guid ArtistId { get; set; }
		public string Description { get; set; }
		public virtual Seguiment Seguiment { get; set; }
		public virtual Genre Genre { get; set; }
		public virtual ICollection<Member> Members { get; set; }
		public bool Ativo { get; set; }
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
