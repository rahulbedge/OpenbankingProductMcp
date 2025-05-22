using OpenbankingProductMcp.Dtos.OpenbankingProducts;

namespace OpenbankingProductMcp.Proxies;

public interface IProductProxy
{
    Task<List<Product>> GetProducts();
    Task<ProductDetails?> GetProductDetails(string productId);
}

