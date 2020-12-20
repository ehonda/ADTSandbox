namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Base.RequestTypes.AllArticles"/>
    public record AllArticles : Base.RequestTypes.AllArticles, IPriceAndStockRequest
    {
    }
}
