using SMSApi.Api.Action.Sender;

namespace SMSApi.Api
{
    public class SenderFactory : Factory
    {
        public SenderFactory() : base() { }
        public SenderFactory(Client client) : base(client) { }
        public SenderFactory(Client client, Proxy proxy) : base(client, proxy) { }

        public SenderAdd ActionAdd(string name = null)
        {
            var action = new SenderAdd();

            action.Client(client);
            action.Proxy(proxy);

            action.SetName(name);

            return action;
        }

        public SenderDelete ActionDelete(string name = null)
        {
            var action = new SenderDelete();

            action.Client(client);
            action.Proxy(proxy);

            action.Name(name);

            return action;
        }

        public SenderSetDefault ActionSetDefault(string name = null)
        {
            var action = new SenderSetDefault();

            action.Client(client);
            action.Proxy(proxy);

            action.Name(name);

            return action;
        }

        public SenderList ActionList()
        {
            var action = new SenderList();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }
    }
}
