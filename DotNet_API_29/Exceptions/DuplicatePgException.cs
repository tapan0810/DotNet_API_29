namespace DotNet_API_29.Exceptions
{
    public class DuplicatePgException:AppException
    {
        public DuplicatePgException(string name)
            :base($"Pg with name {name} already exist.",StatusCodes.Status409Conflict)
        {

        }
    }
}
