namespace Structural.Flyweight
{    
    public class TreeFactory
    {
        private Dictionary<string, TreeType> TreeTypes = new Dictionary<string, TreeType>();
        private TreeType tmpType;

        public TreeType GetTreeType(string name, string color)
        {

            if(name == null || color == null)
                return null;
            tmpType = new TreeType(name,color);
            if(!TreeTypes.ContainsKey(tmpType.GetTreeTypeHashString()))
            {
                TreeTypes.Add(tmpType.GetTreeTypeHashString(), tmpType);
            }

            return TreeTypes[tmpType.GetTreeTypeHashString()];
        }
    }
}
