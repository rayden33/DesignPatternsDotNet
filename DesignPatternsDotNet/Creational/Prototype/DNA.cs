using System.Text;

namespace Creational.Prototype
{
    public class DNA
    {
        public string plnLeftChain;
        private string plnRightCHain;

        public DNA()
        {
            Random rand = new Random();
            int seed = rand.Next(0,10);
            

            plnLeftChain = DNABuilder(seed);
            plnRightCHain = DNABuilder(seed+10);;
        }
        public DNA(DNA source)
        {
            this.plnLeftChain = source.plnLeftChain;
            this.plnRightCHain = source.plnRightCHain;
        }

        public DNA Clone()
        {
            return new DNA(this);
        }

        public string GetPlnRightChainDNA()
        {
            return this.plnRightCHain;
        }

        private string DNABuilder(int seed)
        {
            StringBuilder plnBuilder = new StringBuilder();
            for(int i=0; i<=6; i++)
            {
                plnBuilder.Append((char)((int)'A' + (seed*i%26)));
            }
            return plnBuilder.ToString();
        }
    }
}