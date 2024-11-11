namespace WebApi.Models;

public class ResponseResult : BaseResponseResult
{
}
public class ResponseResult<T> : BaseResponseResult
{
    public T? Data { get; set; }
}

public abstract class BaseResponseResult
{
    public bool Success { get; set; }
    public int StatusCode { get; set; }
    public string? Message { get; set; }

}