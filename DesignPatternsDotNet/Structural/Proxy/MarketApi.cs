namespace Structural.Proxy
{
    public class MarketApi : IMarketApi
    {
        private List<Product> _ProductsList = new List<Product>();
        private int _ApiRequestCount;

        public MarketApi()
        {
            _ProductsList.Add(new Product{Id = 1, Name = "Apple", Price = 10});
            _ProductsList.Add(new Product{Id = 2, Name = "Juice", Price = 100});
            _ProductsList.Add(new Product{Id = 3, Name = "Phone", Price = 3000});
        }

        public Product GetProduct(int productId)
        {
            _ApiRequestCount++;
            return _ProductsList.Where(p => p.Id == productId).FirstOrDefault();
        }

        public int GetApiRequestedCount() => _ApiRequestCount;
    }
}