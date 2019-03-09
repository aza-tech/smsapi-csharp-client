using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class GetContact : Rest<Contact>
	{
		public GetContact(string contactId)
			: base()
		{
			ContactId = contactId;
		}

		protected override string Resource { get { return "contacts/" + ContactId; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }

		private string contactId;
		public string ContactId { get { return contactId; } private set { contactId = value; } }
	}
}
