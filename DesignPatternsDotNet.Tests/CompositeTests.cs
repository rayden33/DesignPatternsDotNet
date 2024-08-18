using Structural.Composite;

public class CompositeTests
{
    [Fact]
    public void CheckToRecursiveMovement()
    {
        GameSceneService gameSceneService = new GameSceneService();
        var mainContainer = new Container(0,0);
        var subContainer = new Container(5,5);
        var cube1 = new Cube(10,10);
        var cube2 = new Cube(20,20);
        var cube3 = new Cube(30,30);
        gameSceneService.AddGameObjectToScene(mainContainer);
        mainContainer.AddChild(subContainer);
        mainContainer.AddChild(cube1);
        subContainer.AddChild(cube2);
        subContainer.AddChild(cube3);

        mainContainer.UnitedMovement(1,1);

        Assert.True(mainContainer.X == 1 && mainContainer.Y == 1 
        && subContainer.X == 6 && subContainer.Y == 6 
        && cube1.X == 11 && cube1.Y == 11
        && cube2.X == 21 && cube2.Y == 21
        && cube3.X == 31 && cube3.Y == 31);

    }
}