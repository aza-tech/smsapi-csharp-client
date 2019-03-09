﻿using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Sender
{
    public class SenderAdd : BaseSimple<Base>
    {
        private string name;

        protected override string Uri() { return "sender.do"; }

        public SenderAdd SetName(string name)
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

            collection.Add("add", name);

            return collection;
        }
    }
}
