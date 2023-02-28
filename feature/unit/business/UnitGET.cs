

using BabelFish;

namespace clean_sharp {
    public class UnitGET : UseCase<string, UnitPokemon>
    {
        UnitRepository repo { get; set; }

        public UnitGET(UnitRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<UnitPokemon> execute(string param)
        {
            var fetch = repo.doFetch();
            return new ValueOutput<UnitPokemon>(fetch);
        }
    }
}
