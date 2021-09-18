using Quickee.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickee.Core.Framework.BaseClass
{
	public abstract class BaseService <T>
	{
		private ApplicationDbContext _dbContext;
		private readonly IServiceProvider _serviceCollection;

		protected ApplicationDbContext DbContext => _dbContext ?? (
			_dbContext = (ApplicationDbContext)_serviceCollection.GetService(typeof(ApplicationDbContext)));

		public BaseService(IServiceProvider services)
		{
			this._serviceCollection = services;
		}
	}
}
