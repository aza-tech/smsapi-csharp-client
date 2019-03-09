using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class DeleteField : Rest<Base>
	{
		public DeleteField(string fieldId)
			: base()
		{
			FieldId = fieldId;
		}

		protected override string Resource { get { return "contacts/fields/" + FieldId; } }

		protected override RequestMethod Method { get { return RequestMethod.DELETE; } }

		private string fieldId;
		public string FieldId { get { return fieldId; } private set { fieldId = value; } }
	}
}
