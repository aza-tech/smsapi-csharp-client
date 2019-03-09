using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class ListFields : Rest<Fields>
	{
		public ListFields ()
			: base()
		{
		}

		protected override string Resource { get { return "contacts/fields"; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }
	}
}
