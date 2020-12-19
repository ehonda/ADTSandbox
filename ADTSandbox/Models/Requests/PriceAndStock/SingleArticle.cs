using ADTSandbox.Models.Base;

namespace ADTSandbox.Models.Requests.PriceAndStock
{
    public record SingleArticle : PriceAndStockRequest, ISingleArticle
    {
        public string Sku { get; init; } = string.Empty;
    }
}
