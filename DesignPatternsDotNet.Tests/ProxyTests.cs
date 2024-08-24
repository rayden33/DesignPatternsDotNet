using System.Text;
using Structural.Proxy;

public class ProxyTests
{
    [Fact]
    public void CheckCacheSystem()
    {
        MarketApiCacheService marketApiCacheService = new MarketApiCacheService(new MarketApi());

        MarketService marketService = new MarketService(marketApiCacheService);

        StringBuilder stringBuilder = new StringBuilder();
        for(int i=0;i<1000;i++)
        {
            stringBuilder.Append(marketService.GetProductInfo(1));
        }
        Assert.True(stringBuilder.Length == 10000 && marketApiCacheService.GetApiRequestedCount() == 1);
    }
}