namespace Structural.Proxy
{
    public class MarketApiCacheService : IMarketApi
    {
        private readonly IMarketApi _MarketApi;
        private List<Product> _CachedProducts = new List<Product>();

        public MarketApiCacheService(IMarketApi marketApi)
        {
            _MarketApi = marketApi;
        }

        public Product GetProduct(int productId)
        {
            if(_CachedProducts.Exists(p => p.Id == productId))
                return _CachedProducts.FirstOrDefault(p => p.Id == productId);
            
            var product = _MarketApi.GetProduct(productId);
            _CachedProducts.Add(product);
            return product;
        }

        public int GetApiRequestedCount() => _MarketApi.GetApiRequestedCount();
    }
}