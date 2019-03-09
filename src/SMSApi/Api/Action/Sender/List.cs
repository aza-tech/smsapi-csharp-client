﻿using System.Collections.Specialized;

namespace SMSApi.Api.Action.Sender
{
    public class SenderList : BaseArray<Response.Sender>
    {
        protected override string Uri() { return "sender.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("list", "1");

            return collection;
        }
    }
}
