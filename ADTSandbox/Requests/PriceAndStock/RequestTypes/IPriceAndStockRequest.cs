using ADTSandbox.Enums.PriceAndStock;
using ADTSandbox.Filters;
using System;

namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <summary>
    /// Request used for price and stock service.
    /// </summary>
    public interface IPriceAndStockRequest
    {
        /// <summary>
        /// Creates a <see cref="IPriceAndStockRequest"/> from the specified
        /// <paramref name="filter"/> if it is set correctly, throws an exception otherwise.
        /// </summary>
        /// <param name="filter">The filter to create the request from.</param>
        /// <returns>The validated request.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown if <paramref name="filter"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     Thrown if property <see cref="PriceAndStockRequestFilter.RequestType"/>
        ///     of <paramref name="filter"/> contains a value that is does not represent
        ///     a valid request type.
        /// </exception>
        public static IPriceAndStockRequest FromFilter(PriceAndStockRequestFilter? filter)
            => filter?.RequestType switch
            {
                null => throw new ArgumentNullException(nameof(filter)),
                RequestType.SingleArticle => SingleArticle.FromFilterData(filter.Sku),
                RequestType.AllArticles => new AllArticles(),
                _ => throw new ArgumentException($"Unkown RequestType enum value: {filter.RequestType}")
            };
    }
}
