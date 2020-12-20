namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Models.Base.SingleArticle"/>
    public record SingleArticle : Models.Base.SingleArticle, IPriceAndStockRequest
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
        /// from a <see cref="Models.Base.SingleArticle"/> by calling the
        /// base copy constructor.
        /// </summary>
        /// <param name="singleArticle">The base single article to construct from.</param>
        public SingleArticle(Models.Base.SingleArticle singleArticle)
            : base(singleArticle)
        {
        }

        /// <inheritdoc cref="Models.Base.SingleArticle.FromFilterData(string?)"/>
        public static new SingleArticle FromFilterData(string? sku)
            => new(Models.Base.SingleArticle.FromFilterData(sku));
    }
}
