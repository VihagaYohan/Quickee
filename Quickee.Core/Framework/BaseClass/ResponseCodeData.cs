using Microsoft.AspNetCore.Http;

namespace Quickee.Core.Framework.BaseClass
{
    public class ResponseCodeData
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public int HttpStatusCode { get; set; } = StatusCodes.Status200OK;
    }
}