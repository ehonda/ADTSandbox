namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Models.RequestTypes.SingleArticle"/>
    public record SingleArticle : Models.RequestTypes.SingleArticle, IPriceAndStockRequest
    {
        /// <summary>
        /// The 0-ary constructor.
        /// </summary>
        public SingleArticle()
            : base()
        {
        }

        /// <summary>
        /// 1-ary constructor, to construct a <see cref="SingleArticle"/>
        /// from a <see cref="Models.RequestTypes.SingleArticle"/> by calling the
        /// base copy constructor.
        /// </summary>
        /// <param name="singleArticle">The base single article to construct from.</param>
        public SingleArticle(Models.RequestTypes.SingleArticle singleArticle)
            : base(singleArticle)
        {
        }

        /// <inheritdoc cref="Models.RequestTypes.SingleArticle.FromFilterData(string?)"/>
        public static new SingleArticle FromFilterData(string? sku)
            => new(Models.RequestTypes.SingleArticle.FromFilterData(sku));
    }
}
