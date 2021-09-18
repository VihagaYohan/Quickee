using Quickee.Core.ApiInputModels.Category;
using Quickee.Core.Entity;
using Quickee.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickee.Core.BusinessLogic.Interface
{
	public interface IProductCategory
	{
		Task<Tuple<bool, object, ResponseCodeData>> GetCategories();

		Task<Tuple<bool, object, ResponseCodeData>> AddCategory(CategoryVM model);
	}
}
