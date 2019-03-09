using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class DeleteContact : Rest<Base>
	{
		public DeleteContact(string contactId)
			: base()
		{
			ContactId = contactId;
		}

		protected override string Resource { get { return "contacts/" + ContactId; } }

		protected override RequestMethod Method { get { return RequestMethod.DELETE; } }

		private string contactId;
		public string ContactId { get { return contactId; } private set { contactId = value; } }
	}
}
