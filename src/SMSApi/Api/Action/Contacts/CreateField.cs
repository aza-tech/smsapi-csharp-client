using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Contacts
{
	public class CreateField : Rest<Field>
	{
		public CreateField()
			: base()
		{
		}

		protected override string Resource { get { return "contacts/fields"; } }

		protected override RequestMethod Method { get { return RequestMethod.POST; } }

		protected override NameValueCollection Parameters
		{
			get
			{
				NameValueCollection parameters = base.Parameters;
				if (Name != null) parameters.Add("name", Name);
				if (Type != null) parameters.Add("type", Type);
				return parameters;
			}
		}

		public string Name;
		public CreateField SetName(string name)
		{
			Name = name;
			return this;
		}

		public string Type;
		public CreateField SetType(string type)
		{
			Type = type;
			return this;
		}
	}
}
