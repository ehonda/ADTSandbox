using ADTSandbox.Requests.PriceAndStock.Enums;
using ADTSandbox.Requests.PriceAndStock.Filters;
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
        //  -> Probably don't care, since we only want to create request from filters

        [Test]
        public void PriceAndStockRequest_From_Null_Filter_Throws()
            => Assert.Catch<ArgumentNullException>(
                () => IPriceAndStockRequest.FromFilter(null));

        [Test]
        public void PriceAndStockRequest_From_Unkown_RequestType_Throws()
            => Assert.Catch<ArgumentException>(
                () => IPriceAndStockRequest.FromFilter(new PriceAndStockRequestFilter
                {
                    RequestType = (RequestType)(-1)
                }));

        [Test]
        public void PriceAndStockRequest_From_SingleArticle_Filter_With_Null_Sku_Throws()
            => Assert.Catch<ArgumentException>(
                () => IPriceAndStockRequest.FromFilter(new PriceAndStockRequestFilter
                {
                    Sku = null,
                    RequestType = RequestType.SingleArticle
                }));

        [Test]
        public void PriceAndStockRequest_From_SingleArticle_Filter_With_Sku_Sets_That_Sku()
        {
            var filter = new PriceAndStockRequestFilter
            {
                Sku = "100",
                RequestType = RequestType.SingleArticle
            };
            var request = IPriceAndStockRequest.FromFilter(filter);

            var expectedRequest = new SingleArticle { Sku = filter.Sku };
            Assert.That(request, Is.EqualTo(expectedRequest));
        }

        [Test]
        public void PriceAndStockRequest_From_AllArticles_Filter_Needs_No_Sku_Set()
        {
            var request = IPriceAndStockRequest.FromFilter(new PriceAndStockRequestFilter
            {
                Sku = null,
                RequestType = RequestType.AllArticles
            });

            var expectedRequest = new AllArticles();
            Assert.That(request, Is.EqualTo(expectedRequest));
        }
    }
}
