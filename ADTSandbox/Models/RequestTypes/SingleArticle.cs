using System;

namespace ADTSandbox.Models.RequestTypes
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

        /// <summary>
        /// Constructs a <see cref="SingleArticle"/> from the provided
        /// filter data if possible, throws an exception otherwise.
        /// </summary>
        /// <param name="sku">The sku.</param>
        /// <returns>A <see cref="SingleArticle"/> with the provided sku.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Thrown if <paramref name="sku"/> is <c>null</c>.
        /// </exception>
        public static SingleArticle FromFilterData(string? sku)
            => sku switch
            {
                null => throw new ArgumentNullException(nameof(sku)),
                string validSku => new SingleArticle { Sku = validSku }
            };
    }
}
