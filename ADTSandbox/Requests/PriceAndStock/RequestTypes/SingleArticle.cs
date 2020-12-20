namespace ADTSandbox.Requests.PriceAndStock.RequestTypes
{
    /// <inheritdoc cref="Base.RequestTypes.SingleArticle"/>
    public record SingleArticle : Base.RequestTypes.SingleArticle, IPriceAndStockRequest
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
        /// from a <see cref="Base.RequestTypes.SingleArticle"/> by calling the
        /// base copy constructor.
        /// </summary>
        /// <param name="singleArticle">The base single article to construct from.</param>
        public SingleArticle(Base.RequestTypes.SingleArticle singleArticle)
            : base(singleArticle)
        {
        }

        /// <inheritdoc cref="Base.RequestTypes.SingleArticle.FromFilterData(string?)"/>
        public static new SingleArticle FromFilterData(string? sku)
            => new(Base.RequestTypes.SingleArticle.FromFilterData(sku));
    }
}
