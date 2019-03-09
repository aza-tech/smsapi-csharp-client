using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class EditField : Rest<Field>
	{
		public EditField(string fieldId)
			: base()
		{
			FieldId = fieldId;
		}

		protected override string Resource { get { return "contacts/fields/" + FieldId; } }

		protected override RequestMethod Method { get { return RequestMethod.PUT; } }

		protected override NameValueCollection Parameters
		{
			get
			{
				NameValueCollection parameters = base.Parameters;
				if (Name != null) parameters.Add("name", Name);
				return parameters;
			}
		}

		private string fieldId;
		public string FieldId { get { return fieldId; } private set { fieldId = value; } }

		public string Name;
		public EditField SetName(string name)
		{
			Name = name;
			return this;
		}
	}
}
