using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Users
    {

        public int CUSTOMER_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public Users(int cUSTOMER_ID, string name, string email, string pass)
        {
            CUSTOMER_ID = cUSTOMER_ID;
            Name = name;
            Email = email;
            Pass = pass;
        }
    
    }
}