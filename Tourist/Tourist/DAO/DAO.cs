using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Tourist.Models;

namespace Tourist.DAO
{
    public class DAO
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public SqlConnection Connection { get; set; }

        public void Connect()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
            Logger.For(this).Info("Connect");
        }

        public void Disconnect()
        {
            Connection.Close();
            Logger.For(this).Info("Disconnect");
        }
    }
}