using Microsoft.EntityFrameworkCore;
using Quickee.Core.ApiInputModels.Category;
using Quickee.Core.BusinessLogic.Interface;
using Quickee.Core.Entity;
using Quickee.Core.Framework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickee.Core.BusinessLogic.Service
{
	public class ProductCategories : BaseService<ProductCategories>, IProductCategory
	{
		public ProductCategories(IServiceProvider services) : base(services)
		{

		}

		public async Task<Tuple<bool, object, ResponseCodeData>> AddCategory(CategoryVM model)
		{
			try
			{
				var category = new ProductCategory()
				{
					CategoryName = model.CategoryName
				};

				DbContext.Categories.Add(category);
				var result = await DbContext.SaveChangesAsync();

				return new Tuple<bool, object, ResponseCodeData>(true, result, ResponseCodes.Success);
			}
			catch (Exception ex)
			{
				return new Tuple<bool, object, ResponseCodeData>(false, ex, ResponseCodes.Failed);
			}
		}

		public async Task<Tuple<bool, object, ResponseCodeData>> GetCategories()
		{
			try
			{
				var result = await DbContext.Categories.ToListAsync();

				return new Tuple<bool, object, ResponseCodeData>(true, result, ResponseCodes.Success);
			}
			catch (Exception ex)
			{
				return new Tuple<bool, object, ResponseCodeData>(false, ex, ResponseCodes.Failed);
			}
		}
	}
}
