namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Models.Base.AllArticles"/>
    public record AllArticles : Models.Base.AllArticles, IPriceAndStockRequest
    {
    }
}
