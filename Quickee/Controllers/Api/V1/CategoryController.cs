using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Quickee.Core.Framework.BaseClass;

namespace Quickee.Controllers.Api.V1
{
    [ApiVersion(APIV1Number)]
    [Route(APIPath)]
    [ApiController]
    public class CategoryController : BaseController
    {
        public readonly  List<string> Fruits = new List<string> {"Mango, Orange, Banana"};
        // GET
        [HttpGet]
        public IActionResult GetFruits()
        {
            return Ok(Fruits);
        }
    }
}