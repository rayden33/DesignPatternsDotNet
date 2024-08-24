using Structural.Flyweight;
public class FlyweightTest
{
    [Fact]
    public void CacheTest()
    {
        var service = new ForestService();
        service.GenerateTrees(3,1);
        var list = service.GetTrees();

        Assert.True(list[0].Type == list[1].Type && list[1].Type == list[2].Type&&list[2].Type != list[3].Type);
    }
}