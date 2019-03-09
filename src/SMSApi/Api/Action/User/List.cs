﻿using System.Collections.Specialized;

namespace SMSApi.Api.Action.User
{
    public class UserList : BaseArray<Response.User>
    {
        public UserList() : base() { }

        protected override string Uri() { return "user.do"; }

        protected override NameValueCollection Values()
        {
            NameValueCollection collection = new NameValueCollection();

            collection.Add("format", "json");

            collection.Add("username", client.GetUsername());
            collection.Add("password", client.GetPassword());

            collection.Add("list", "1");

            return collection;
        }

        protected string username;

        public UserList Username(string username)
        {
            this.username = username;
            return this;
        }
    }
}
