using SMSApi.Api.Action.HLR;

namespace SMSApi.Api
{
    public class HLRFactory : Factory
    {
        public HLRFactory() : base() { }
        public HLRFactory(Client client) : base(client) { }

        public HLRFactory(Client client, Proxy proxy) : base(client, proxy)
        {
        }

        public HLRCheckNumber ActionCheckNumber(string number = null)
        {
            var action = new HLRCheckNumber();

            action.Client(client);
            action.Proxy(proxy);

            action.SetNumber(number);

            return action;
        }
    }
}
