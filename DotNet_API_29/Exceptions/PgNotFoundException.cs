namespace DotNet_API_29.Exceptions
{
    public class PgNotFoundException:AppException
    {
        public PgNotFoundException(int id) : base($"Pg with id {id} not found", StatusCodes.Status404NotFound) { }
    }
}
