using System.Collections.Generic;
using BabelFish;

namespace clean_sharp
{
    class UnitPresenterImpl : BaseController, UnitPresenter
    {
        UnitGET get { get; set; }

        public UnitPresenterImpl(UnitGET get){
            this.get = get;
        }

        public List<UnitPokemon> doFetch()
        {
            
            throw new System.NotImplementedException();
        }
    }
}