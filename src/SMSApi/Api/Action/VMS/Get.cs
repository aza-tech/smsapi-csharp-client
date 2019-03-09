using System.Collections.Specialized;

namespace SMSApi.Api.Action.VMS
{
    public class VMSGet : BaseSimple<Response.Status>
    {
        public VMSGet() : base() { }

        protected override string Uri() { return "vms.do"; }

        protected string[] ids;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("status", string.Join("|", ids));

            return collection;
        }

        public VMSGet Id(string id)
        {
            this.ids = new string[] { id };
            return this;
        }


        public VMSGet Ids(string[] ids)
        {
            this.ids = ids;
            return this;
        }
    }
}
