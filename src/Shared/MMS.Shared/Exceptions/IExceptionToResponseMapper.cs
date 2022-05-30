namespace MMS.Shared.Exceptions;

internal interface IExceptionToResponseMapper
{
    ExceptionResponse Map(Exception exception);
}