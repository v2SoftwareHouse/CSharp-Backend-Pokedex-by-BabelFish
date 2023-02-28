using System.Collections.Generic;

namespace clean_sharp
{
    class UnitRepositoryImpl : UnitRepository
    {
        UnitPokemon UnitRepository.doFetch()
        {
            try
            {
                return new UnitPokemon("Bulbasaur");
            }
            catch
            {
                throw new System.NotImplementedException();
            }
        }
    }
}