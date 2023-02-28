

using BabelFish;

namespace clean_sharp {
    public class SequenceGETBulbasaur : UseCase<string, SequencePokemon>
    {
        SequenceRepository repo { get; set; }

        public SequenceGETBulbasaur(SequenceRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<SequencePokemon> execute(string param)
        {
            var sequence = repo.getBulbasaur();
            return new ValueOutput<SequencePokemon>(sequence);
        }
    }
}
