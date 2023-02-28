using System.Collections.Generic;
using BabelFish;

namespace clean_sharp
{
    class SequencePresenterImpl : BaseController, SequencePresenter
    {
       SequenceGETBulbasaur getBulbasaur {get;set;}
       SequenceGETIvysaur getIvysaur {get;set;}
       SequenceGETVenusaur getVenusaur {get;set;}
        public SequencePresenterImpl(SequenceGETBulbasaur getBulbasaur, SequenceGETIvysaur getIvysaur, SequenceGETVenusaur getVenusaur){
            this.getBulbasaur = getBulbasaur;
            this.getIvysaur = getIvysaur;
            this.getVenusaur = getVenusaur;
        }

        public List<SequencePokemon> doFetch()
        {
       
            var sequence = SequenceUseCase.Builder()
            .add(getBulbasaur)
            .add(getIvysaur)
            .add(getVenusaur)
            .build();
       
            return processUseCase(null, sequence)?.value;
        }
    }
}