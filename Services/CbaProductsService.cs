using OpenbankingProductMcp.Dtos.OpenbankingProducts;
using OpenbankingProductMcp.Proxies;

namespace OpenbankingProductMcp.Services;

public class CbaProductsService(IProductProxy productProxy)
{
    private List<Product> _productList = [];

    public async Task<List<Product>> GetProducts()
    {
        try
        {
            if (_productList?.Count > 0)
                return _productList;

            _productList = await productProxy.GetProducts();
            return _productList;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting products: {ex.Message}");
            throw;
        }
    }

    public async Task<ProductDetails?> GetProductDetails(string productId)
    {
        try
        {
            return await productProxy.GetProductDetails(productId);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting product details: {ex.Message}");
            throw;
        }
    }
}