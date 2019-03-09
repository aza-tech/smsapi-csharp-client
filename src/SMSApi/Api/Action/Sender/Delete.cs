using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Sender
{
    public class SenderDelete : BaseSimple<Base>
    {
        protected override string Uri() { return "sender.do"; }

        private string name;

        public SenderDelete Name(string name)
        {
            this.name = name;
            return this;
        }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("delete", this.name);

            return collection;
        }
    }
}
