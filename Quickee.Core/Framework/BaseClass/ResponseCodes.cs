using Microsoft.AspNetCore.Http;

namespace Quickee.Core.Framework.BaseClass
{
    public static class ResponseCodes
    {
        public static ResponseCodeData Success { get;  } =
            new ResponseCodeData{Message="Success", Status=0};

        public static ResponseCodeData BadData { get; } =
            new ResponseCodeData {Message = "Bad Data", Status = 2, HttpStatusCode = StatusCodes.Status400BadRequest};
        
        public static ResponseCodeData NotFound { get; } = 
            new ResponseCodeData {Message ="Not Found", Status = 3, HttpStatusCode = StatusCodes.Status404NotFound};

        public static ResponseCodeData Failed { get; } =
            new ResponseCodeData { Message = "Internet server error", Status = 4, HttpStatusCode = StatusCodes.Status500InternalServerError};
    }
}