﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;

//namespace ContactsListLatest.Controllers
//{
//    public class ContactsController : ApiController
//    {
//    }
//}

using ContactsListLatest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContactsListLatest.Controllers
{
    public class ContactsController : ApiController
    {
        //[HttpGet]
        //public IEnumerable<Contact> Get()
        //{
        //    return new Contact[]{
        //        new Contact { Id = 1, EmailAddress = "barney@contoso.com", Name = "Barney Poland"},
        //        new Contact { Id = 2, EmailAddress = "lacy@contoso.com", Name = "Lacy Barrera"},
        //        new Contact { Id = 3, EmailAddress = "lora@microsoft.com", Name = "Lora Riggs"},
        //        new Contact { Id = 4, EmailAddress = "laura@microsoft.com", Name = "Laura Means"},
        //        new Contact { Id = 5, EmailAddress = "vivienne@microsoft.com", Name = "Vivienne Stark"},
        //        new Contact { Id = 6, EmailAddress = "fiona@microsoft.com", Name = "Fiona Riggs"}
        //    };
        //}

        [HttpGet]
        public IEnumerable<Account> GetAccounts()
        {
            return new Account[]{
                new Account { Id = 1, TE = "Matt", Name = "PayPal"},
                new Account { Id = 2, TE = "Richard", Name = "Netflix"},
                new Account { Id = 3, TE = "Nathalie", Name = "Twitch"},

            };
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] Contact contact)
        {
            // todo: save the contact somewhere
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}