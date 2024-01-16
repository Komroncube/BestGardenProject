using BestGarden.Application.DTOs.Products;

namespace BestGarden.Application.UseCases.Products.Commands.CreateProduct;
public class CreateProductCommand : ICommand<Product>
{
    public ProductCreateDTO ProductCreateDto { get; set; }
}
