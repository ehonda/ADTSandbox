using ADTSandbox.Enums.PriceAndStock;
using ADTSandbox.Filters;
using System;

namespace ADTSandbox.Models.Requests.PriceAndStock
{
    /// <summary>
    /// Request used for price and stock service.
    /// </summary>
    public interface IPriceAndStockRequest
    {
        public static IPriceAndStockRequest FromFilter(PriceAndStockRequestFilter? filter)
            => filter?.RequestType switch
            {
                null => throw new ArgumentNullException(nameof(filter)),
                RequestType.SingleArticle => SingleArticle.FromFilterData(filter.Sku),
                RequestType.AllArticles => new AllArticles()
            };
    }
}
