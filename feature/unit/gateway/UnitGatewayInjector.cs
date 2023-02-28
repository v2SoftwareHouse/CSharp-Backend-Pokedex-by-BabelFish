

namespace clean_sharp {
    public sealed class UnitGatewayInjector
    {
        static UnitGatewayInjector _self;
        public static UnitGatewayInjector Self
        {
            get { return _self ?? (_self = new UnitGatewayInjector()); }
        }

        private UnitGatewayInjector() { }
        public UnitGET fetch;
    }
}