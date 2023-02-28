

using BabelFish;
using System.Collections.Generic;

namespace clean_sharp {
    public class ChainGETIvysaur : UseCase<List<ChainPokemon>, ChainPokemon>
    {
        ChainRepository repo { get; set; }

        public ChainGETIvysaur(ChainRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<ChainPokemon> execute(List<ChainPokemon> param)
        {
            var chain = repo.getIvysaur();
            return new ValueOutput<ChainPokemon>(chain);
        }
    }
}
