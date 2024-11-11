using WebApi.Factories;
using WebApi.Models;

namespace WebApi.Services;

public class ProductService //(DataContext context)

{
    //private readonly DataContext _context = context;

    public async  Task<ResponseResult> Create(ProductRegistrationForm form)
    {
        var entity = ProductFactory.Create(form);

        //if (await _context.Products.AnyAsync(x => x.Title == entity.Title)) 
        //    return ResponseResultFactory.Exists<ResponseResult>();
        // _context.Products.Add(entity);
        // await _context.SaveChangesAsync();

        var product = ProductFactory.Create(entity);
        var result = ResponseResultFactory.Success<Product>(data: product);

        return result;

    }
}
