using AllScene.Domain.Entities;
using AllScene.Domain.Interfaces.Repository;
using AllScene.Domain.Specifications.Genres;
using DomainValidation.Validation;

namespace AllScene.Domain.Validations.Genres
{
	public class GenreSuitableForRegistrationValidation : Validator<Genre>
	{
		public GenreSuitableForRegistrationValidation(IGenreRepository genreRepository)
		{
			var duplicateDescription = new GenreUpMustHaveUniqueDescriptionSpecification(genreRepository);
			base.Add("duplicateDescription", new Rule<Genre>(duplicateDescription, "Descrição já cadastrada!"));
		}
	}
}
