namespace DotNet_API_29.Exceptions
{
    public class PgException:Exception
    {
        public int StatusCode { get; }

        protected PgException(string message ,int statusCode):base (message)
        {
            StatusCode = statusCode;
        }
    }
}
