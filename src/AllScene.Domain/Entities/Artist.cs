using System;
using System.Collections.Generic;

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
		public virtual Genre genre { get; set; }
		public virtual ICollection<Member> Members { get; set; }
		#endregion

		#region Methods
		#endregion
	}
}
