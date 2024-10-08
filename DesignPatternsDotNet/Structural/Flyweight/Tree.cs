namespace Structural.Flyweight
{
    public class Tree
    {
        public int X {get; set;}
        public int Y {get; set;}
        public TreeType Type {get; set;}

        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public string GetFruit() => Type.GetFruit(X,Y);
    }
}