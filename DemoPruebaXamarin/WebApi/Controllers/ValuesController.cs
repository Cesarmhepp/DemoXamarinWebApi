using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            var retVal = new { key1 = "value1", key2 = "value2" };
            return Request.CreateResponse(HttpStatusCode.OK, retVal);
        }

        // GET api/values/5
        public List<Users> Get(string email, string passwd)
        {
            
            MySqlConnection conn = WebApiConfig.conn();
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = "select * from testuser where EMAIL=" + email+ "and PASS="+passwd;

            var users = new List<Users>();

            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
             //   users.Add(new Users(0,null,null,null,ex.ToString()));
                
            }

            MySqlDataReader fetch_query = query.ExecuteReader();

            while (fetch_query.Read())
            {
            //    users.Add(new Users(int.Parse(fetch_query["CUSTOMER_ID"].ToString()), fetch_query["EMAIL"].ToString(), fetch_query["PASS"].ToString(), null, fetch_query["NAME"].ToString()));
            }

            return users;

        }

        
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
