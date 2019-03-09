using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Phonebook
{
    public class PhonebookGroupList : BaseSimple<Groups>
    {
        public PhonebookGroupList()
            : base()
        {
        }

        protected override string Uri() { return "phonebook.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("list_groups", "");

            return collection;
        }
    }
}
