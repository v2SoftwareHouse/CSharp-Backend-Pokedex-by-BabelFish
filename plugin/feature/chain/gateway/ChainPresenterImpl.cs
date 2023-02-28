
using System.Collections.Generic;
using BabelFish;

namespace clean_sharp
{
    class ChainPresenterImpl : BaseController, ChainPresenter
    {
        ChainGETBulbasaur getBulbasaur {get;set;}
        ChainGETBulbasaur getIvysaur {get;set;}
        public ChainPresenterImpl(ChainGETBulbasaur getBulbasaur, ChainGETIvysaur getIvysaur){
            this.getBulbasaur = getBulbasaur;
            this.getIvysaur = getIvysaur;
        }

        public List<ChainPokemon> doFetch()
        {
            var chainedUseCase = ChainedUseCase(getBulbasaur, getIvysaur);
            
            throw new System.NotImplementedException();
        }
    }
}