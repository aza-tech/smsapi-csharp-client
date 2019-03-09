using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class ListFieldOptions : Rest<FieldOptions>
	{
		public ListFieldOptions(string fieldId)
			: base()
		{
			FieldId = fieldId;
		}

		protected override string Resource { get { return "contacts/fields/" + FieldId + "/options"; } }

		protected override RequestMethod Method { get { return RequestMethod.GET; } }

		private string fieldId;
		public string FieldId { get { return fieldId; } private set { fieldId = value; } }
	}
}
