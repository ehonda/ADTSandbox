using ADTSandbox.Enums.PriceAndStock;

namespace ADTSandbox.Filters
{
    /// <summary>
    /// The filter to construct a price and stock request from.
    /// </summary>
    public record PriceAndStockRequestFilter
    {
        /// <summary>
        /// The articles' sku. Needs to be set if <see cref="RequestType"/>
        /// is <see cref="RequestType.SingleArticle"/>, is ignored otherwise.
        /// </summary>
        public string? Sku { get; init; }

        /// <summary>
        /// The request type. Available values are:
        /// <list type="bullet">
        /// <item>
        ///     <term><see cref="RequestType.SingleArticle"/></term>
        ///     <description>A request for a single article.</description>
        /// </item>
        /// <item>
        ///     <term><see cref="RequestType.AllArticles"/></term>
        ///     <description>A request for all articles.</description>
        /// </item>
        /// </list>
        /// </summary>
        public RequestType RequestType { get; init; }
    }
}
