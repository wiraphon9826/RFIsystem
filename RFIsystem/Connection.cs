using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RFIsystem
{
    public class Connection
    {
        public IConfiguration Configuration;


        public static string GetConnectionString()
        {
            return Startup.ConnectionString;
        }
        public SqlConnection connectionDB()
        {
           
            SqlConnection sqlcon = new SqlConnection(); 
            string sqlconstr = GetConnectionString();

            sqlcon.ConnectionString = sqlconstr;

            if (sqlcon != null || sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();



            }
            return sqlcon;
        }


    }

}
