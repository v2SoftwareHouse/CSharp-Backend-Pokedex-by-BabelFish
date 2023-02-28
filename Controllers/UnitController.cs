

using System;
using Microsoft.AspNetCore.Mvc;
using BabelFish;

namespace clean_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitController : BaseController
    {
        private readonly Lazy<UnitGET> fetcher = new Lazy<UnitGET>(() => UnitGatewayInjector.Self.fetch);
        
        public UnitPokemon doFetch(string name)
        {
            return processUseCase<string, UnitPokemon>(name, fetcher.Value).value;
        }

        [HttpGet]
        public string Get()
        {
            var process = doFetch("");
            
            return process.ToString();
        }
    }
}

