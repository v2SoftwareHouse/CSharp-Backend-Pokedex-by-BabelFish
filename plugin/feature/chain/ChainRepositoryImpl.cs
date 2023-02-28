using System.Collections.Generic;

namespace clean_sharp
{
    class ChainRepositoryImpl : ChainRepository
    {
        public ChainPokemon getBulbasaur()
        {
            return mockFecth("Bulbasaur");
        }

        public ChainPokemon getIvysaur()
        {
            return mockFecth("Ivysaur");
        }

        private ChainPokemon mockFecth(string pokemon){
            try
            {
                return new ChainPokemon(pokemon);
            }
            catch
            {
                throw new System.NotImplementedException();
            }
        }
    }
}