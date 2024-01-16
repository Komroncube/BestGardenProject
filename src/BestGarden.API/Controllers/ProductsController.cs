using BestGarden.Application.DTOs.Products;
using BestGarden.Application.UseCases.Products.Commands.CreateProduct;
using BestGarden.Application.UseCases.Products.Commands.DeleteProduct;
using BestGarden.Application.UseCases.Products.Queries.GetProductDetail;
using BestGarden.Application.UseCases.Products.Queries.GetProductList;
using BestGarden.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BestGarden.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        IEnumerable<ProductListDTO> productList = await _mediator.Send(new GetProductListQuery());
        return Ok(productList);
    }

    [HttpGet("{id}")]
    public async Task<Product> Get(int id)
    {
        return await _mediator.Send(new GetProductDetailQuery { Id = id });
    }

    [HttpPost]
    public async ValueTask<IActionResult> Post([FromForm] ProductCreateDTO productCreateDto)
    {
        Product product = await _mediator.Send(new CreateProductCommand { ProductCreateDto = productCreateDto });
        return Ok(product);
    }

    [HttpDelete("{id}")]
    public async ValueTask<IActionResult> Delete(int id)
    {
        bool result = await _mediator.Send(new DeleteProductCommand { Id = id });
        return Ok(result);
    }
}
