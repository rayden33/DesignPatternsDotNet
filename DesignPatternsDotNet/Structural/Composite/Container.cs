namespace Structural.Composite
{
    public class Container : GameObject
    {
        private List<GameObject> _children = new List<GameObject>();
        public Container(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override void UnitedMovement(int x, int y)
        {
            base.UnitedMovement(x, y);

            foreach (var child in _children)
                child.UnitedMovement(x, y);
        }

        public override void AddChild(GameObject gameObject) => _children.Add(gameObject);
        public override void RemoveChild(GameObject gameObject) => _children.Remove(gameObject);
    }
}