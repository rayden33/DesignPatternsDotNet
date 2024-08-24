namespace Structural.Proxy
{    
    public interface IMarketApi
    {
        public Product GetProduct(int productId);
        public int GetApiRequestedCount();
    }
}
