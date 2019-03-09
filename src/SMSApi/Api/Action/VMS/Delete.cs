using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.VMS
{
    public class VMSDelete : BaseSimple<Countable>
    {
        public VMSDelete() : base() { }

        protected override string Uri() { return "vms.do"; }

        protected string[] ids;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("sch_del", string.Join("|", ids));

            return collection;
        }

        public VMSDelete Id(string id)
        {
            this.ids = new string[] { id };
            return this;
        }

        public VMSDelete Ids(string[] ids)
        {
            this.ids = ids;
            return this;
        }
    }
}
