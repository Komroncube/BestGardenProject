namespace BestGarden.Application.UseCases.Products.Commands.DeleteProduct;
public class DeleteProductCommand : ICommand<bool>
{
    public int Id { get; set; }
}
