using System;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using DomainValidation.Interfaces.Specification;

namespace AllScene.Domain.Specifications.Genres
{
	public class GenreUpMustHaveUniqueDescriptionSpecification : ISpecification<Genre>
	{
		#region Atributes
		private readonly IGenreRepository _genreRepository;
		#endregion

		#region Constructors

		public GenreUpMustHaveUniqueDescriptionSpecification(IGenreRepository genreRepository)
		{
			_genreRepository = genreRepository;
		}
		#endregion

		#region Métodos
		public bool IsSatisfiedBy(Genre genre)
		{
			return _genreRepository.GetByDescription(genre.Description) == null;
		}
		#endregion
	}
}
