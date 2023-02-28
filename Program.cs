using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace clean_sharp
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Unnit.Self.fetch = new LandingUseCase(new LandingRepositoryImpl());
            LandingGatewayInjector.Self.fetch = new LandingUseCase(new LandingRepositoryImpl());
            ChainGatewayInjector.Self.fetch = new ChainUseCase(new ChainRepositoryImpl());
            SequenceGatewayInjector.Self.fetch = new SequenceUseCase(new SequenceRepositoryImpl());
    
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
