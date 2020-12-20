namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Models.RequestTypes.AllArticles"/>
    public record AllArticles : Models.RequestTypes.AllArticles, IPriceAndStockRequest
    {
    }
}
