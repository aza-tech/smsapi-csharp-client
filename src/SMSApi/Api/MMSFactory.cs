using SMSApi.Api.Action.MMS;

namespace SMSApi.Api
{
    public class MMSFactory : Factory
    {
        public MMSFactory() : base() { }
        public MMSFactory(Client client) : base(client) { }
        public MMSFactory(Client client, Proxy proxy) : base(client, proxy) { }

        public MMSDelete ActionDelete(string id = null)
        {
            MMSDelete action = new MMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public MMSGet ActionGet(string id = null)
        {
            MMSGet action = new MMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public MMSGet ActionGet(string[] id)
        {
            MMSGet action = new MMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public MMSSend ActionSend(string to = null)
        {
            string[] tos = ( to == null ? null : new string[] { to } );
            return ActionSend(tos);
        }

        public MMSSend ActionSend(string[] to)
        {
            MMSSend action = new MMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);

            return action;
        }
    }
}
