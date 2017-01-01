using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AllScene.Domain.Entities;
using AllScene.Infra.Data.EntityConfig;
using System.Linq;
using System;

namespace AllScene.Infra.Data.Context
{
	public class AllSceneContext : DbContext
	{
		#region Constructors
		public AllSceneContext():base("AllScene"){}
		#endregion

		#region Properties
		public DbSet<Seguiment> Seguiments { get; set; }
		public DbSet<Member> Members { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Artist> Artists { get; set; }
		#endregion

		#region Methods

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			// General Custom Context Properties
			modelBuilder.Properties()
				.Where(p => p.Name == p.ReflectedType.Name + "Id")
				.Configure(p => p.IsKey());

			modelBuilder.Properties<string>()
				.Configure(p => p.HasColumnType("varchar"));

			modelBuilder.Properties<string>()
				.Configure(p => p.HasMaxLength(100));

			modelBuilder.Configurations.Add(new SeguimentConfig());
			modelBuilder.Configurations.Add(new GenreConfig());
			modelBuilder.Configurations.Add(new MemberConfig());
			modelBuilder.Configurations.Add(new ArtistConfig());

			base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
					entry.Property("DateLastModfield").IsModified = false;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DateLastModfield").CurrentValue = DateTime.Now;
					entry.Property("RegistrationDate").IsModified = false;
				}
			}
			return base.SaveChanges();

		}
		#endregion
	}
}
