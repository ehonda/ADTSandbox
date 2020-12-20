namespace ADTSandbox.Models.Requests.PriceAndStock
{
    /// <inheritdoc cref="Base.AllArticles"/>
    public record AllArticles : Base.AllArticles, IPriceAndStockRequest
    {
    }
}
