using System.ComponentModel;
using System.Text.Json;
using ModelContextProtocol.Server;
using OpenbankingProductMcp.Services;

namespace OpenbankingProductMcp;

[McpServerToolType]
public static class EchoProduct
{
    [McpServerTool, Description("Get all cba products.")]
    public static async Task<string> GetAllCbaProducts(CbaProductsService cbaProductsService)
    {
        var products = await cbaProductsService.GetProducts();
        return JsonSerializer.Serialize(products);
    }

    [McpServerTool, Description("Get product details by product ID.")]
    public static async Task<string> GetCbaProductDetails(CbaProductsService cbaProductsService, [Description("The ID of the product to get details for")] string productId)
    {
        var product = await cbaProductsService.GetProductDetails(productId);
        return JsonSerializer.Serialize(product);
    }

}