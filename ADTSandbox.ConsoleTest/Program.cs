using ADTSandbox.Requests.PriceAndStock.RequestTypes;
using System;

namespace ADTSandbox.ConsoleTest
{
    class Program
    {
        private static IPriceAndStockRequest GetRequest()
            => new SingleArticle { Sku = "100" };

        public static void Main(string[] args)
        {
            var request = GetRequest();

            if (request is SingleArticle singleArticle)
            {
                Console.WriteLine($"Sku = {singleArticle.Sku}");
                var otherSingleArticle = new SingleArticle(singleArticle);
            }

            // TODO: This only generates a warning, how do we deal with it?
            //  - Throw on null in property init?
            var nullSkuRequest = new SingleArticle { Sku = null };
        }
    }
}
