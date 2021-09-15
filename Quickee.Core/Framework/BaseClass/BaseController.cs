using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Quickee.Core.Framework.BaseClass
{
    public abstract class BaseController:ControllerBase
    {
        public const string APIPath = "api/v{version:apiVersion}/[controller]";
        public const string APIV1Number = "1.0";
        public const string APIV2Number = "2.0";
        [NonAction]
        
        public IActionResult SendResponse(dynamic data, ResponseCodeData code = null)
        {
            if (code == null)
            {
                code = new ResponseCodeData()
                {
                    Message = "Success",
                    Status =  0,
                    HttpStatusCode = StatusCodes.Status200OK
                };
            }

            var response = new
            {
                code = new
                {
                    Message = code.Message,
                    Status = code.Status
                },
                data = data
            };
            return StatusCode(code.HttpStatusCode, response);
        }
    }
}