using System;
using DomainValidation.Validation;

namespace AllScene.Domain.Entities
{
	public class Member
	{
		#region Constructor

		public Member()
		{
			MemberId = Guid.NewGuid();
		}
		#endregion

		#region Properties

		public Guid MemberId { get; set; }
		public string Name { get; set; }
		public string Nickname { get; set; }
		public DateTime DateBirth { get; set; }
		public string Gender { get; set; }
		public Guid ArtistId { get; set; }
		public virtual Artist Artist { get; set; }
		public bool Active { get; set; }
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
