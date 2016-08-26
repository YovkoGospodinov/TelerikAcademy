namespace Bunnies.Factory
{
    using System.Collections.Generic;
    using Bunnies.Models;

    public class BunniesFactory
    {
        private IList<Bunny> bunnies;

        public BunniesFactory(IList<Bunny> bunnies)
        {
            this.bunnies = bunnies;
        }

        public IList<Bunny> Bunnies => this.bunnies;

        public void AddBunny(Bunny bunny)
        {
            this.bunnies.Add(bunny);
        }
    }
}
