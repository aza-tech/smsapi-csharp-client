﻿using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action.Phonebook
{
    public class PhonebookGroupGet : BaseSimple<Group>
    {
        public PhonebookGroupGet() : base() { }

        protected override string Uri() { return "phonebook.do"; }

        protected string name;

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("get_group", name);

            return collection;
        }

        public PhonebookGroupGet Name(string name)
        {
            this.name = name;
            return this;
        }
    }
}
