

using BabelFish;

namespace clean_sharp {
    public class SequenceGETIvysaur : UseCase<string, SequencePokemon>
    {
        SequenceRepository repo { get; set; }

        public SequenceGETIvysaur(SequenceRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<SequencePokemon> execute(string param)
        {
            var sequence = repo.getIvysaur();
            return new ValueOutput<SequencePokemon>(sequence);
        }
    }
}
