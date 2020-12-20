using ADTSandbox.Requests.PriceAndStock.RequestTypes;
using NUnit.Framework;
using System;

namespace ADTSandbox.Tests
{
    public class PriceAndStockRequestTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleArticle_Request_Is_Default_Constructible_With_Empty_Sku()
        {
            var request = new SingleArticle();
            Assert.That(request.Sku, Is.EqualTo(string.Empty));
        }

        [Test]
        public void SingleArticle_Request_Is_Copy_Constructible()
        {
            var request = new SingleArticle();
            var copiedRequest = new SingleArticle(request);
            Assert.That(request, Is.EqualTo(copiedRequest));
        }

        // TODO: How do we deal with null skus?

        [Test]
        public void PriceAndStockRequest_From_Null_Filter_Throws()
        {
            Assert.Catch<ArgumentNullException>(() => IPriceAndStockRequest.FromFilter(null));
        }
    }
}