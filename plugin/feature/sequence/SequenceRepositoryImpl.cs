using System.Collections.Generic;

namespace clean_sharp
{
    class SequenceRepositoryImpl : SequenceRepository
    {
        public SequencePokemon getBulbasaur()
        {
            return mockFecth("Bulbasaur");
        }

        public SequencePokemon getIvysaur()
        {
            return mockFecth("Ivysaur");
        }

        public SequencePokemon getVenusaur()
        {
           return mockFecth("Venusaur");
        }

        private SequencePokemon mockFecth(string pokemon){
            try
            {
                return new SequencePokemon(pokemon);
            }
            catch
            {
                throw new System.NotImplementedException();
            }
        }
    }
}