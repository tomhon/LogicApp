using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//namespace ContactsListLatest.Models
//{
//    public class Contact
//    {
//    }
//}

namespace ContactsListLatest.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        public string TE { get; set; }
        public string Name { get; set; }
    }
}