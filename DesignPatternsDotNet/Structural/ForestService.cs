using System.Text;

namespace Structural.Flyweight
{
    public class ForestService
    {
        private List<Tree> _ForestTrees;
        private readonly TreeFactory _TreeFactory = new TreeFactory();

        public void GenerateTrees(int greenEucalyptusCount, int redAcerPalmatumCount)
        {
            _ForestTrees = new List<Tree>();

            for(int i=0;i<greenEucalyptusCount;i++)
            {
                TreeType type = _TreeFactory.GetTreeType("Eucalyptus", "green");
                _ForestTrees.Add(new Tree(i, greenEucalyptusCount - i, type));
            }

            for(int i=0;i<redAcerPalmatumCount;i++)
            {
                TreeType type = _TreeFactory.GetTreeType("AcerPalmatum","red");
                _ForestTrees.Add(new Tree(redAcerPalmatumCount-i, i, type));
            }

        }

        public string GetForestTreesFruits()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var tree in _ForestTrees)
                stringBuilder.AppendLine(tree.GetFruit());

            return stringBuilder.ToString();
        }

        public List<Tree> GetTrees() => _ForestTrees;
        
    }
}