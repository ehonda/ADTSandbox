namespace ADTSandbox.Models.Base
{
    /// <summary>
    /// Request representing a single article identified
    /// via it's <see cref="Sku"/>.
    /// </summary>
    public record SingleArticle
    {
        /// <summary>
        /// The articles' sku.
        /// </summary>
        public string Sku { get; init; } = string.Empty;
    }
}
