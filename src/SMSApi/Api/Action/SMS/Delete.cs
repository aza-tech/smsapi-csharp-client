using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.SMS
{
    public class SMSDelete : BaseSimple<Countable>
    {
        public SMSDelete() : base() { }

        protected override string Uri() { return "sms.do"; }

        protected string id;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("sch_del", id);

            return collection;
        }

        public SMSDelete Id(string id)
        {
            this.id = id;
            return this;
        }
    }
}
