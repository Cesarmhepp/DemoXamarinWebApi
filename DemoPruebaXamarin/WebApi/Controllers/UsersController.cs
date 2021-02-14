using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsersController : ApiController
    {
        MySqlConnection conn = WebApiConfig.conn();
        public HttpResponseMessage Get()
        {
            try
            {
                string query = @"SELECT * from testuser;";
                DataTable table = new DataTable();
                using (var cmd = new MySqlCommand(query, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return Request.CreateResponse(HttpStatusCode.OK,table);
            }
            catch (Exception)
            {

                return Request.CreateResponse("Failed to Add");
            }
        }

        public HttpResponseMessage Get(int id)
        {
            try
            {
                string query = @"SELECT * from testuser where CUSTOMER_ID="+id+";";
                DataTable table = new DataTable();
                using (var cmd = new MySqlCommand(query, conn))
                using (var da = new MySqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return Request.CreateResponse(HttpStatusCode.OK, table);
            }
            catch (Exception)
            {

                return Request.CreateResponse("Failed to Add");
            }
        }
        [ResponseType(typeof(Users))]
        public string Post(Users us)
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
                    if (table1.Rows.Count==1)
                    {
                        return "The Email already Exist";
                    }
                    else
                    {
                        string query = @"INSERT INTO TESTUSER (EMAIL,PASS,NAME)VALUES('" + us.Email + @"','" + us.Pass + @"','" + us.Name + @"');";
                        DataTable table = new DataTable();
                        using (var cmd = new MySqlCommand(query, conn))
                        using (var da = new MySqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.Text;
                            da.Fill(table);
                        }
                        return "Added Successfully";
                    }
                }

            }
            catch (Exception)
            {

                return "Failed to Add";
            }
        }

        

        

    }
}
