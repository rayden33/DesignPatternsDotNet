namespace Structural.Composite
{
    public class Cube : GameObject
    {
        public Cube(int x, int y)
        {
            base.UnitedMovement(x,y);
        }
        public override void UnitedMovement(int x, int y) => base.UnitedMovement(x, y);
    }
}