using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using AllScene.Domain.Entities;

namespace AllScene.Infra.Data.EntityConfig
{
	public class ArtistConfig : EntityTypeConfiguration<Artist>
	{
		#region Constructors

		public ArtistConfig()
		{
			HasKey(c => c.ArtistId);

			Property(c => c.Description)
				.IsRequired()
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

			Property(c => c.Active)
				.IsRequired();

			HasRequired(e => e.Seguiment)
				.WithOptional(o => o.Artist);

			Ignore(c => c.ValidationResult);
		}
		#endregion
	}
}
