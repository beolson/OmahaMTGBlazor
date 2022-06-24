namespace OmahaMRG.Application.Common.Exceptions
{
    public class NotAuthorizedException : Exception
    {
        public NotAuthorizedException(string userName, string className, string functionName)
            : base($"unauthorized access by user \"{userName}\" Class: \"{className}\" Function:  \"{functionName}\"")
        {
        }
    }
}