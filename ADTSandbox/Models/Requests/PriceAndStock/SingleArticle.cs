namespace ADTSandbox.Models.Requests.PriceAndStock
{
    /// <inheritdoc cref="Base.SingleArticle"/>
    public record SingleArticle : Base.SingleArticle, IPriceAndStockRequest
    {
        /// <inheritdoc cref="Base.SingleArticle.FromFilterData(string?)"/>
        public static new SingleArticle FromFilterData(string? sku)
            => (SingleArticle)Base.SingleArticle.FromFilterData(sku);
    }
}
