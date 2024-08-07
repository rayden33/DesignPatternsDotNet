using System.Text;

namespace Creational.Prototype
{
    public class Cell
    {
        public int CellPower;
        public DateTime BirthDate;
        private DNA cellDNA;

        public Cell(int cellPower)
        {
            CellPower = cellPower;
            cellDNA = new DNA();
            BirthDate = DateTime.Now;
        }

        public Cell Clone()
        {
            Cell clone = (Cell) this.MemberwiseClone();
            clone.cellDNA = cellDNA.Clone();
            return clone;
        }

        public string ShowDNA()
        {
            return $"{this.cellDNA.plnLeftChain}\n{this.cellDNA.GetPlnRightChainDNA()}";
        }

        public void DNAMutation()
        {
            StringBuilder rev = new StringBuilder();
            foreach(char c in cellDNA.plnLeftChain)
                rev.Append(c+"m");
            
            cellDNA.plnLeftChain = rev.ToString();
        }
    }
}