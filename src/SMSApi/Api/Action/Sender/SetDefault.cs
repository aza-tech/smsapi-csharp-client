﻿using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Sender
{
    public class SenderSetDefault : BaseSimple<Base>
    {
        protected override string Uri() { return "sender.do"; }

        private string name;

        public SenderSetDefault Name(string name)
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

            collection.Add("default", this.name);

            return collection;
        }
    }
}
