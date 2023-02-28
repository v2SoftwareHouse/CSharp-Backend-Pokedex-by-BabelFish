
using System.Collections.Generic;
using BabelFish;

namespace clean_sharp
{
    class ChainPresenterImpl : BaseController, ChainPresenter
    {
        ChainGETBulbasaur getBulbasaur {get;set;}
        ChainGETIvysaur getIvysaur {get;set;}
        public ChainPresenterImpl(ChainGETBulbasaur getBulbasaur, ChainGETIvysaur getIvysaur){
            this.getBulbasaur = getBulbasaur;
            this.getIvysaur = getIvysaur;
        }

        public List<ChainPokemon> doFetch()
        {
            var chainedUseCase = new ChainedUseCase(getBulbasaur, getIvysaur);
            return processUseCase(null, chainedUseCase)?.value;
        }
    }
}