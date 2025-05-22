using System.Net.Http.Json;
using OpenbankingProductMcp.Dtos.OpenbankingProducts;

namespace OpenbankingProductMcp.Proxies;

public class ProductProxy : IProductProxy
{
    private readonly HttpClient _httpClient;

    public ProductProxy(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api.commbank.com.au/public/cds-au/v1/banking/");
    }

    private async Task<T?> GetAsync<T>(string endpoint, int version) where T : class
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
        request.Headers.Add("x-v", version.ToString());
        
        var response = await _httpClient.SendAsync(request);
        return response.IsSuccessStatusCode 
            ? await response.Content.ReadFromJsonAsync<T>() 
            : null;
    }

    public async Task<List<Product>> GetProducts()
    {
        var response = await GetAsync<ProductListResponse>("products?page-size=1000", 3);
        return response?.Data?.Products ?? [];
    }

    public async Task<ProductDetails?> GetProductDetails(string productId)
    {
        var response = await GetAsync<ProductDetailsResponse>($"products/{productId}", 4);
        return response?.Data;
    }
}