namespace MMS.Shared.Exceptions;

public abstract class MMSException : Exception
{
    protected MMSException(string message) : base(message)
    {
    }
}