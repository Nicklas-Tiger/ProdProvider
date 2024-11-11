using WebApi.Models;

namespace WebApi.Factories;

public static class ResponseResultFactory
{
    public static ResponseResult Success(int statusCode = 200, string message = null!)
    {
        return new ResponseResult
        {
            Success = true,
            StatusCode = statusCode,
            Message = message,
        };
    }
    public static ResponseResult<T> Success<T>(int statusCode = 200, T data = default!, string message = null!)
    {
        return new ResponseResult<T>
        {
            Success = true,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
    public static ResponseResult Failure(int statusCode = 400, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
        };
    }
    public static ResponseResult Exists(int statusCode = 409, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
        };
    }
    public static ResponseResult NotFound(int statusCode = 404, string message = null!)
    {
        return new ResponseResult
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
        };
    }
}
