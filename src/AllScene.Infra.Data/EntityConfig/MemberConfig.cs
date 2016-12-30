using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using AllScene.Domain.Entities;

namespace AllScene.Infra.Data.EntityConfig
{
	public class MemberConfig : EntityTypeConfiguration<Member>
	{
		#region Constructos

		public MemberConfig()
		{
			HasKey(c => c.MemberId);

			Property(c => c.Name)
				.IsRequired()
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

			Property(c => c.Nickname)
				.HasMaxLength(50);

			Property(c => c.DateBirth)
				.IsRequired()
				.HasColumnType("Date");

			Property(c => c.Gender)
				.HasMaxLength(1);

			Property(c => c.Active)
				.IsRequired();

			HasRequired(e => e.Artist)
				.WithMany(c => c.Members)
				.HasForeignKey(e => e.ArtistId);

			Ignore(c => c.ValidationResult);
		}
		#endregion
	}
}
