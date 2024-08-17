namespace Structural.Composite
{
    public abstract class GameObject
    {
        public int X {get; set;}
        public int Y {get; set;}

        public virtual void UnitedMovement(int x, int y)
        {
            X += x;
            Y += y;
        }

        public virtual void AddChild(GameObject gameObject) => throw new NotImplementedException();
        public virtual void RemoveChild(GameObject gameObject) => throw new NotImplementedException();
    }
}