

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BabelFish;

namespace clean_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChainController : BaseController
    {
        private readonly Lazy<ChainUseCase> fetcher = new Lazy<ChainUseCase>(() => ChainGatewayInjector.Self.fetch);
        
        public Chain doFetch(string name)
        {
            var chainUseCase
            return processUseCase<string, Chain>(name, ChainGatewayInjector.Self.fetch).value;
        }

        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            var process = doFetch("");
            return process.results.AsEnumerable();
        }
    }
}

