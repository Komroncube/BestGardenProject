namespace BestGarden.Application.UseCases.Products.Queries.GetProductDetail;
public class GetProductDetailQuery : IQuery<Product>
{
    public int Id { get; set; }
}
