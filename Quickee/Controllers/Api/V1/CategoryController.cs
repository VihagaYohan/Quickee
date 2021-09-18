using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quickee.Core.ApiInputModels.Category;
using Quickee.Core.BusinessLogic.Interface;
using Quickee.Core.Framework.BaseClass;

namespace Quickee.Controllers.Api.V1
{
    [ApiVersion(APIV1Number)]
    [Route(APIPath)]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly IProductCategory _productService;

        public CategoryController(IProductCategory productService)
		{
            this._productService = productService;
		}

        public readonly  List<string> Fruits = new List<string> {"Mango, Orange, Banana"};
        // GET
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _productService.GetCategories();
            return SendResponse(result.Item2);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryVM category) 
        {
            var result = await _productService.AddCategory(category);
            return SendResponse(result.Item2);
        }
    }
}