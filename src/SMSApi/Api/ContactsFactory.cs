using SMSApi.Api.Action.Contacts;

namespace SMSApi.Api
{
	public class ContactsFactory : Factory
	{
		public ContactsFactory(Client client) : base(client)
		{
			ProxyHTTP proxyHttp = new ProxyHTTP("http://api.smsapi.pl/");
			proxyHttp.BasicAuthentication(client);
			Proxy(proxyHttp);
		}

        public ContactsFactory(Client client, Proxy proxy) : base(client, proxy)
        {
            proxy.BasicAuthentication(client);
            Proxy(proxy);
        }

        public ListContacts ListContacts()
		{
			ListContacts action = new ListContacts();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public CreateContact CreateContact()
		{
			CreateContact action = new CreateContact();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public DeleteContact DeleteContact(string contactId)
		{
			DeleteContact action = new DeleteContact(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public GetContact GetContact(string contactId)
		{
			GetContact action = new GetContact(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public EditContact EditContact(string contactId)
		{
			EditContact action = new EditContact(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public ListGroups ListGroups()
		{
			ListGroups action = new ListGroups();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public CreateGroup CreateGroup()
		{
			CreateGroup action = new CreateGroup();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public DeleteGroup DeleteGroup(string groupId)
		{
			DeleteGroup action = new DeleteGroup(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public GetGroup GetGroup(string groupId)
		{
			GetGroup action = new GetGroup(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public EditGroup EditGroup(string groupId)
		{
			EditGroup action = new EditGroup(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}
	
		public ListGroupPermissions ListGroupPermissions(string groupId)
		{
			ListGroupPermissions action = new ListGroupPermissions(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public ListFields ListFields()
		{
			ListFields action = new ListFields();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public CreateField CreateField()
		{
			CreateField action = new CreateField();
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public DeleteField DeleteField(string fieldId)
		{
			DeleteField action = new DeleteField(fieldId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public EditField EditField(string fieldId)
		{
			EditField action = new EditField(fieldId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public ListFieldOptions ListFieldOptions(string fieldId)
		{
			ListFieldOptions action = new ListFieldOptions(fieldId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public BindContactToGroup BindContactToGroup(string contactId, string groupId)
		{
			BindContactToGroup action = new BindContactToGroup(contactId, groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public UnbindContactFromGroup UnbindContactFromGroup(string contactId, string groupId)
		{
			UnbindContactFromGroup action = new UnbindContactFromGroup(contactId, groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public ListContactGroups ListContactGroups(string contactId)
		{
			ListContactGroups action = new ListContactGroups(contactId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public GetContactGroup GetContactGroup(string contactId, string groupId)
		{
			GetContactGroup action = new GetContactGroup(contactId, groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public CreateGroupPermission CreateGroupPermission(string groupId)
		{
			CreateGroupPermission action = new CreateGroupPermission(groupId);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public DeleteGroupPermission DeleteGroupPermission(string groupId, string username)
		{
			DeleteGroupPermission action = new DeleteGroupPermission(groupId, username);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public GetGroupPermission GetGroupPermission(string groupId, string username)
		{
			GetGroupPermission action = new GetGroupPermission(groupId, username);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}

		public EditGroupPermission EditGroupPermission(string groupId, string username)
		{
			EditGroupPermission action = new EditGroupPermission(groupId, username);
			action.Client(client);
			action.Proxy(proxy);
			return action;
		}
	}
}

