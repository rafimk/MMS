using System.Net;

namespace MMS.Shared.Exceptions;

public sealed record ExceptionResponse(object Response, HttpStatusCode StatusCode);