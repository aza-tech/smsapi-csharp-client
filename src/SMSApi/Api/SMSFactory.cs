
using SMSApi.Api.Action.SMS;

namespace SMSApi.Api
{
    public class SMSFactory : Factory
    {
        public SMSFactory() : base() { }
        public SMSFactory(Client client) : base(client) { }

        public SMSFactory(Client client, Proxy proxy) : base(client, proxy) { }

        public SMSDelete ActionDelete(string id = null)
        {
            SMSDelete action = new SMSDelete();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public SMSGet ActionGet(string id = null)
        {
            SMSGet action = new SMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Id(id);

            return action;
        }

        public SMSGet ActionGet(string[] id)
        {
            SMSGet action = new SMSGet();

            action.Client(client);
            action.Proxy(proxy);
            action.Ids(id);

            return action;
        }

        public SMSSend ActionSend(string to = null, string text = null)
        {
            string[] tos = ( to == null ? null : new string[] { to } );
            return ActionSend(tos, text);
        }

        public SMSSend ActionSend(string[] to, string text = null)
        {
            SMSSend action = new SMSSend();
            action.Client(client);
            action.Proxy(proxy);
            action.SetTo(to);
            action.SetText(text);

            return action;
        }
    }
}
