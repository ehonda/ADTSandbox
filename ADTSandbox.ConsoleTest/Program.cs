using ADTSandbox.Models.Requests.PriceAndStock;
using System;

namespace ADTSandbox.ConsoleTest
{
    class Program
    {
        private static PriceAndStockRequest GetRequest()
            => new SingleArticle { Sku = "100" };

        public static void Main(string[] args)
        {
            var request = GetRequest();

            if (request is SingleArticle singleArticle)
                Console.WriteLine($"Sku = {singleArticle.Sku}");
        }
    }
}
