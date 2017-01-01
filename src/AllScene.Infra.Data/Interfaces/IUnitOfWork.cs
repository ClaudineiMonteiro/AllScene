namespace AllScene.Infra.Data.Interfaces
{
	public interface IUnitOfWork
	{
		void BeginTransection();
		void Commit();
	}
}
