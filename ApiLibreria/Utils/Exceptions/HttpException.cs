using System.Net;

namespace Utils.Exceptions
{
    public class HttpException : Exception
    {
        public string Message { get; set; }
        public HttpStatusCode ErrorCode { get; set; }
        public HttpException(string message, HttpStatusCode errorCode = HttpStatusCode.InternalServerError)
        {
            Message = message;
            ErrorCode = errorCode;
        }
    }
}
