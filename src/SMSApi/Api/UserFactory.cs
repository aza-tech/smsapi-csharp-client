using SMSApi.Api.Action.User;

namespace SMSApi.Api
{
    public class UserFactory : Factory
    {
        public UserFactory() : base() { }
        public UserFactory(Client client) : base(client) { }
        public UserFactory(Client client, Proxy proxy) : base(client, proxy) { }

        public UserGetCredits ActionGetCredits()
        {
            var action = new UserGetCredits();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }

        public UserAdd ActionAdd()
        {
            var action = new UserAdd();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }

        public UserEdit ActionEdit(string username = null)
        {
            var action = new UserEdit();

            action.Client(client);
            action.Proxy(proxy);

            action.Username(username);

            return action;
        }

        public UserGet ActionGet(string username = null)
        {
            var action = new UserGet();

            action.Client(client);
            action.Proxy(proxy);

            action.Username(username);

            return action;
        }

        public UserList ActionList()
        {
            var action = new UserList();

            action.Client(client);
            action.Proxy(proxy);

            return action;
        }
    }
}
