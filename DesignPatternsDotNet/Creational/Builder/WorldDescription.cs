using System.Text;

namespace Creational.Builder
{
    public class WorldDescription
    {
        public WorldDescription()
        {
            Random rand = new Random();
            WorldSeed = rand.Next();
            _description.AppendLine($"World [{WorldSeed}]");
        }
        public WorldDescription(int worldSeed)
        {
            WorldSeed = worldSeed;
            _description.AppendLine($"World [{WorldSeed}]");
        }

        public int WorldSeed {get; private set;}
        public StringBuilder _description = new StringBuilder();

        public void AddLakes() => _description.AppendLine("with lakes for swimming");
        public void AddWings() => _description.AppendLine("with wings for flight");
        public void AddEnemy() => _description.AppendLine("with enemies to fight");

        public string GetWorldDescription() => _description.ToString();

    }
}