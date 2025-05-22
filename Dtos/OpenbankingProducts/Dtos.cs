using System.Text.Json.Serialization;

namespace OpenbankingProductMcp.Dtos.OpenbankingProducts;


// TODO: Rearrange the classes
public class Feature
{
    [JsonPropertyName("featureType")]
    public string? FeatureType { get; set; }
    
    [JsonPropertyName("additionalValue")]
    public string? AdditionalValue { get; set; }
    
    [JsonPropertyName("additionalInfo")]
    public string? AdditionalInfo { get; set; }
    
    [JsonPropertyName("additionalInfoUri")]
    public string? AdditionalInfoUri { get; set; }
}

public class Eligibility
{
    [JsonPropertyName("eligibilityType")]
    public string? EligibilityType { get; set; }
    
    [JsonPropertyName("additionalInfo")]
    public string? AdditionalInfo { get; set; }
}

public class Fee
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("feeType")]
    public string? FeeType { get; set; }
    
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }
    
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
    
    [JsonPropertyName("additionalInfo")]
    public string? AdditionalInfo { get; set; }
    
    [JsonPropertyName("transactionRate")]
    public string? TransactionRate { get; set; }
}

public class ProductDetails : Product
{
    [JsonPropertyName("features")]
    public List<Feature>? Features { get; set; }
    
    [JsonPropertyName("eligibility")]
    public List<Eligibility>? Eligibility { get; set; }
    
    [JsonPropertyName("fees")]
    public List<Fee>? Fees { get; set; }
    
    [JsonPropertyName("additionalInformation")]
    public AdditionalInformation? AdditionalInformation { get; set; }
    
    [JsonPropertyName("isTailored")]
    public bool IsTailored { get; set; }
}

public class AdditionalInformation
{
    [JsonPropertyName("overviewUri")]
    public string? OverviewUri { get; set; }
    
    [JsonPropertyName("termsUri")]
    public string? TermsUri { get; set; }
    
    [JsonPropertyName("eligibilityUri")]
    public string? EligibilityUri { get; set; }
    
    [JsonPropertyName("feesAndPricingUri")]
    public string? FeesAndPricingUri { get; set; }
}

public class Product
{
    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("brand")]
    public string? Brand { get; set; }
    
    [JsonPropertyName("brandName")]
    public string? BrandName { get; set; }
    
    [JsonPropertyName("lastUpdated")]
    public string? LastUpdated { get; set; }
    
    [JsonPropertyName("effectiveFrom")]
    public string? EffectiveFrom { get; set; }
    
    [JsonPropertyName("effectiveTo")]
    public string? EffectiveTo { get; set; }
    
    [JsonPropertyName("productCategory")]
    public string? ProductCategory { get; set; }
}

public class ProductResponse
{
    [JsonPropertyName("data")]
    public Product? Data { get; set; }
    
    [JsonPropertyName("links")]
    public Links? Links { get; set; }
    
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
}

public class ProductListResponse
{
    [JsonPropertyName("data")]
    public ProductsData? Data { get; set; }
    
    [JsonPropertyName("links")]
    public Links? Links { get; set; }
    
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
}

public class ProductsData
{
    [JsonPropertyName("products")]
    public List<Product>? Products { get; set; }
}

public class Links
{
    [JsonPropertyName("self")]
    public string? Self { get; set; }
    
    [JsonPropertyName("first")]
    public string? First { get; set; }
    
    [JsonPropertyName("prev")]
    public string? Prev { get; set; }
    
    [JsonPropertyName("next")]
    public string? Next { get; set; }
    
    [JsonPropertyName("last")]
    public string? Last { get; set; }
}

public class Meta
{
    [JsonPropertyName("totalRecords")]
    public int? TotalRecords { get; set; }
    
    [JsonPropertyName("totalPages")]
    public int? TotalPages { get; set; }
}

public class ProductDetailsResponse
{
    [JsonPropertyName("data")]
    public ProductDetails? Data { get; set; }
    
    [JsonPropertyName("links")]
    public Links? Links { get; set; }
    
    [JsonPropertyName("meta")]
    public Meta? Meta { get; set; }
}