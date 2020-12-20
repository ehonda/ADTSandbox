namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Base.RequestTypes.SingleArticle"/>
    public record SingleArticle : Base.RequestTypes.SingleArticle, IPriceAndStockRequest
    {
        /// <inheritdoc cref="Base.RequestTypes.SingleArticle.FromFilterData(string?)"/>
        public static new SingleArticle FromFilterData(string? sku)
            => new()
            {
                Sku = Base.RequestTypes.SingleArticle.FromFilterData(sku).Sku
            };
    }
}
