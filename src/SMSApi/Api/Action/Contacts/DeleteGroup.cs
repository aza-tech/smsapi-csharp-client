using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class DeleteGroup : Rest<Base>
	{
		public DeleteGroup(string groupId)
			: base()
		{
			GroupId = groupId;
		}

		protected override string Resource { get { return "contacts/groups/" + GroupId; } }

		protected override RequestMethod Method { get { return RequestMethod.DELETE; } }

		private string groupId;
		public string GroupId { get { return groupId; } private set { groupId = value; } }
	}
}
