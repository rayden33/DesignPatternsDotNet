namespace Structural.Flyweight
{
    public class TreeType
    {
        public readonly string Name;
        public readonly string Color;

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string GetTreeTypeHashString() => $"{Name}-{Color}";

        public string GetFruit(int x, int y) => $"{Name} tree get produces {Color} fruit at {x} {y} coordinates";
    }
}
