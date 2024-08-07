using System.Text;
namespace Creational.Prototype
{
    public class LabaratoryService
    {
        public string ExperimentWithCells()
        {
            StringBuilder result = new StringBuilder();
            Labaratory lab = new Labaratory(100);
            lab.DuplicateSourceCell();
            lab.MutationSourceCell();

            result.AppendLine("Source cell DNA:");
            result.AppendLine(lab.GetSourceCellDNA());
            result.AppendLine("Prototype cell DNA:");
            result.AppendLine(lab.GetPrototypeCellDNA());

            return result.ToString();
        }
    }
}