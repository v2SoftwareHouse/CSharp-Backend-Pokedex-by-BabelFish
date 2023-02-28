

using BabelFish;
using System.Collections.Generic;

namespace clean_sharp {
    public class ChainGETBulbasaur : UseCase<Void, List<ChainPokemon>>
    {
        ChainRepository repo { get; set; }

        public ChainGETBulbasaur(ChainRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<List<ChainPokemon>> execute(Void param)
        {
            var bulbasaur = repo.getBulbasaur();
            var chain = new List<ChainPokemon>();
            chain.Add(bulbasaur);

            return new ValueOutput<List<ChainPokemon>>(chain);
        }
    }
}
