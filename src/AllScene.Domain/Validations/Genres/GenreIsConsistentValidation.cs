using System.Linq.Expressions;
using AllScene.Domain.Entities;
using DomainValidation.Validation;

namespace AllScene.Domain.Validations.Genres
{
	public class GenreIsConsistentValidation : Validator<Genre>
	{
		#region Methods

		public bool IsSatisfiedBy(Genre genre)
		{
			return genre.Description.Length > 0;
		}
		#endregion
	}
}
