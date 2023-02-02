

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BabelFish;

namespace clean_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        private readonly Lazy<LandingUseCase> fetcher = new Lazy<LandingUseCase>(() => LandingGatewayInjector.Self.fetch);
        
        public Landing doFetch(string name)
        {
            return processUseCase<string, Landing>(name, LandingGatewayInjector.Self.fetch).value;
        }

        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            var process = doFetch("");
            return process.results.AsEnumerable();
        }
    }
}

