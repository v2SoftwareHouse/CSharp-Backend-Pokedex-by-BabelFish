

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BabelFish;

namespace clean_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SequenceController : BaseController
    {
        private readonly Lazy<SequenceGETBulbasaur> fetchBulbasaur = new Lazy<SequenceGETBulbasaur>(() => SequenceGatewayInjector.Self.fetchBulbasaur);
        private readonly Lazy<SequenceGETIvysaur> fetchIvysaur = new Lazy<SequenceGETIvysaur>(() => SequenceGatewayInjector.Self.fetchIvysaur);
        private readonly Lazy<SequenceGETVenusaur> fetchVenusaur = new Lazy<SequenceGETVenusaur>(() => SequenceGatewayInjector.Self.fetchVenusaur);

        public SequencePokemon doFetch(string name)
        {
            var sequence = SequenceUseCase


            // return processUseCase<string, SequencePokemon>(name, fetchBulbasaur).value;
        }

        [HttpGet]
        public IEnumerable<SequencePokemon> Get()
        {
            var process = doFetch("");
            return process.results.AsEnumerable();
        }
    }
}

