using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.User
{
    public class UserGetCredits : BaseSimple<Credits>
    {
        public UserGetCredits() : base() { }

        protected override string Uri() { return "user.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("credits", "1");
            collection.Add("details", "1");

            return collection;
        }
    }
}
