
using SMSApi.Api.Action.VMS;

namespace SMSApi.Api
{
    public class VMSFactory : Factory
    {
        public VMSFactory() : base() { }
        public VMSFactory(Client client) : base(client) { }

        public VMSFactory(Client client, Proxy proxy) : base(client, proxy)
        {
        }

        public VMSDelete ActionDelete(string id = null)
        {
            VMSDelete action = new VMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public VMSGet ActionGet(string id = null)
        {
            VMSGet action = new VMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public VMSGet ActionGet(string[] id)
        {
            VMSGet action = new VMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public VMSSend ActionSend(string to = null)
        {
            string[] tos = ( to == null ? null : new string[] { to } );
            return ActionSend(tos);
        }

        public VMSSend ActionSend(string[] to)
        {
            VMSSend action = new VMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);

            return action;
        }
    }
}
