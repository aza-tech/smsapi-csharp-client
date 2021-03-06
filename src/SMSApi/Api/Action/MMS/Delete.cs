﻿using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.MMS
{
    public class MMSDelete : BaseSimple<Countable>
    {
        public MMSDelete() : base() { }

        protected override string Uri() { return "mms.do"; }

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

        public MMSDelete Id(string id)
        {
            this.ids = new string[] { id };
            return this;
        }

        public MMSDelete Ids(string[] ids)
        {
            this.ids = ids;
            return this;
        }
    }
}
