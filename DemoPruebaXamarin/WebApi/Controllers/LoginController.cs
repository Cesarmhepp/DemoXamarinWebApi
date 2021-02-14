using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class LoginController : ApiController
    {
        MySqlConnection conn = WebApiConfig.conn();
        public HttpResponseMessage Post(Users us)
        {
            try
            {
                string query1 = @"SELECT * from testuser where email='" + us.Email + "';";
                DataTable table1 = new DataTable();
                using (var cmd1 = new MySqlCommand(query1, conn))
                using (var da1 = new MySqlDataAdapter(cmd1))
                {
                    cmd1.CommandType = CommandType.Text;
                    da1.Fill(table1);
                    if (table1.Rows.Count == 1)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, table1);
                    }
                    else
                    {
                        return Request.CreateResponse("The Email or Password are incorrent");

                    }
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse("The Email or Password are incorrent" + ex);
            }
        }
    }
}
