namespace ADTSandbox.Models.Requests.PriceAndStock
{
    /// <inheritdoc cref="Base.SingleArticle"/>
    public record SingleArticle : Base.SingleArticle, IPriceAndStockRequest
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
        /// from a <see cref="Base.SingleArticle"/> by calling the
        /// base copy constructor.
        /// </summary>
        /// <param name="singleArticle">The base single article to construct from.</param>
        public SingleArticle(Base.SingleArticle singleArticle)
            : base(singleArticle)
        {
        }

        /// <inheritdoc cref="Base.SingleArticle.FromFilterData(string?)"/>
        public static new SingleArticle FromFilterData(string? sku)
            => new(Base.SingleArticle.FromFilterData(sku));
    }
}
