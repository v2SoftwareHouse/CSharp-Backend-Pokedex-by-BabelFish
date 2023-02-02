

using BabelFish;

namespace clean_sharp {
    public class LandingUseCase : UseCase<string, Landing>
    {
        LandingRepository repo { get; set; }

        public LandingUseCase(LandingRepository repo) : base() {
            this.repo = repo;
        }

        public override Output<Landing> execute(string param)
        {
            var landing = repo.doFetch();
            return new ValueOutput<Landing>(landing);
        }
    }
}
