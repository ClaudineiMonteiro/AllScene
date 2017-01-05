using AllScene.Domain.Entities;
using DomainValidation.Interfaces.Specification;

namespace AllScene.Domain.Specifications.Genres
{
	public class GenreMustHaveCompletedDescriptionValidoSpecification : ISpecification<Genre>
	{
		public bool IsSatisfiedBy(Genre genre)
		{
			return genre.Description.Length > 0;
		}
	}
}
