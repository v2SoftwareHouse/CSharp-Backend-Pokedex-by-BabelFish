

namespace clean_sharp {
    public sealed class ChainGatewayInjector
    {
        static ChainGatewayInjector _self;
        public static ChainGatewayInjector Self
        {
            get { return _self ?? (_self = new ChainGatewayInjector()); }
        }

        private ChainGatewayInjector() { }
        public ChainGETBulbasaur fetchBulbasaur;
        public ChainGETIvysaur fetchIvysaur;
    }
}