namespace Structural.Proxy
{
    public class MarketService
    {
        private readonly IMarketApi _MarketApi;

        public MarketService(IMarketApi marketApi)
        {
            _MarketApi = marketApi;
        }

        public string GetProductInfo(int productId)
        {
            var product = _MarketApi.GetProduct(productId);

            return $"{product.Id}-{product.Name}-{product.Price}";
        }
    }
}
