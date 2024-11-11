using WebApi.Factories;
using WebApi.Models;

namespace WebApi.Tests;

public class ResponseResultFactory_Tests
{
    private ProductEntity _entityWithData = new ProductEntity
    {
        Id = 1,
        Title = "Test product",
        Price = 200
    };

    [Fact]  
    public void Success_ShouldReturnSuccessAndStatusCode200()
    {
        // Act
        var result = ResponseResultFactory.Success();

        // Assert 
        Assert.IsType<ResponseResult>(result);
        Assert.True(result.Success);
        Assert.Equal(200, result.StatusCode);
    }
    [Fact]
    public void SuccessWithStatusCode201_ShouldReturnSuccessAndStatusCode201()
    {
        // Act
        var result = ResponseResultFactory.Success(statusCode: 201);

        // Assert 
        Assert.IsType<ResponseResult>(result);
        Assert.True(result.Success);
        Assert.Equal(201, result.StatusCode);
    }
    [Fact]
    public void SuccessWithProductEntity_ShouldReturnSuccesstrueAndStatusCode200AndDat()
    {
        // Act
        var result = ResponseResultFactory.Success<ProductEntity>(data: _entityWithData);

        // Assert 
        Assert.IsType<ResponseResult<ProductEntity>>(result);
        Assert.True(result.Success);
        Assert.Equal(200, result.StatusCode);
        Assert.Equal(_entityWithData, result.Data);
    }
    [Fact]
    public void Failure_ShouldReturnSuccessFalseAndStatusCode400()
    {
        // Act
        var result = ResponseResultFactory.Failure();

        // Assert 
        Assert.IsType<ResponseResult>(result);
        Assert.False(result.Success);
        Assert.Equal(400, result.StatusCode);
    }

    [Fact]
    public void Exists_ShouldReturnSuccessFalseAndStatusCode409()
    {
        // Act
        var result = ResponseResultFactory.Exists();

        // Assert 
        Assert.IsType<ResponseResult>(result);
        Assert.False(result.Success);
        Assert.Equal(409, result.StatusCode);
    }
    [Fact]
    public void NotFound_ShouldReturnSuccessFalseAndStatusCode404()
    {
        // Act
        var result = ResponseResultFactory.NotFound();

        // Assert 
        Assert.IsType<ResponseResult>(result);
        Assert.False(result.Success);
        Assert.Equal(404, result.StatusCode);
    }
}
