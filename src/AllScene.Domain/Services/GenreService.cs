using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Domain.Interfaces.Service;

namespace AllScene.Domain.Services
{
	public class GenreService : IGenreService
	{
		#region Attributes
		private readonly IGenreRepository _genreRepository;
		#endregion

		#region Constructors
		public GenreService(IGenreRepository genreRepository)
		{
			_genreRepository = genreRepository;
		}
		#endregion

		#region Methods
		public void Dispose()
		{
			_genreRepository.Dispose();
			GC.SuppressFinalize(this);
		}

		public Genre Add(Genre genre)
		{
			return _genreRepository.Add(genre);
		}

		public Genre GetById(Guid id)
		{
			return _genreRepository.GetById(id);
		}

		public Genre GetByDescription(string description)
		{
			return _genreRepository.GetByDescription(description);
		}

		public IEnumerable<Genre> GetAll()
		{
			return _genreRepository.GetAll();
		}

		public void Remove(Guid id)
		{
			_genreRepository.Remove(id);
		}

		Genre IGenreService.Update(Genre genre)
		{
			return _genreRepository.Update(genre);
		}
		#endregion
	}
}
