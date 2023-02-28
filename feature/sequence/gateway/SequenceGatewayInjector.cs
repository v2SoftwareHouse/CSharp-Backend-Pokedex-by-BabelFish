

namespace clean_sharp {
    public sealed class SequenceGatewayInjector
    {
        static SequenceGatewayInjector _self;
        public static SequenceGatewayInjector Self
        {
            get { return _self ?? (_self = new SequenceGatewayInjector()); }
        }

        private SequenceGatewayInjector() { }
        public SequenceGETBulbasaur fetchBulbasaur;
        public SequenceGETIvysaur fetchIvysaur;
        public SequenceGETVenusaur fetchVenusaur;
    }
}