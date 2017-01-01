using System;
using AllScene.Infra.Data.Context;
using AllScene.Infra.Data.Interfaces;

namespace AllScene.Infra.Data.UoW
{
	public class UnitOfWork :IUnitOfWork
	{
		#region Attributes

		private readonly AllSceneContext _context;
		private bool _disposed;
		#endregion

		#region Constructors

		public UnitOfWork(AllSceneContext context)
		{
			_context = context;
		}
		#endregion

		#region Methods
		public void BeginTransection()
		{
			_disposed = false;
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
