

using BabelFish;

namespace clean_sharp {
    public class SequenceGETVenusaur : UseCase<string, SequencePokemon>
    {
        SequenceRepository repo { get; set; }

        public SequenceGETVenusaur(SequenceRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<SequencePokemon> execute(string param)
        {
            var sequence = repo.getVenusaur();
            return new ValueOutput<SequencePokemon>(sequence);
        }
    }
}
