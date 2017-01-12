using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using AllScene.Domain.Entities;

namespace AllScene.Infra.Data.EntityConfig
{
	public class SegmentConfig : EntityTypeConfiguration<Segment>
	{
		#region Constructors
		public SegmentConfig()
		{
			HasKey(c => c.SegmentId);

			Property(c => c.Description)
				.IsRequired()
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

			Ignore(c => c.ValidationResult);
		}
		#endregion
	}
}
