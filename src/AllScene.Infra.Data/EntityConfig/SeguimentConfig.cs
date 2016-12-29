using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using AllScene.Domain.Entities;

namespace AllScene.Infra.Data.EntityConfig
{
	class SeguimentConfig : EntityTypeConfiguration<Seguiment>
	{
		#region Constructors
		public SeguimentConfig()
		{
			HasKey(c => c.ArtistId);

			Property(c => c.Description)
				.IsRequired()
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

			Ignore(c => c.ValidationResult);
		}
		#endregion
	}
}
