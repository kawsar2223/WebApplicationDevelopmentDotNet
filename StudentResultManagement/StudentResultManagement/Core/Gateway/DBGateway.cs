using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StudentResultManagement.Core.Gateway
{
    public class DBGateway
    {
        private SqlConnection connectionObj;
        private SqlCommand commandObj;
        public SqlConnection ConnectionObj
        {
            get
            {
                return connectionObj;
            }
        }

        public SqlCommand CommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }

        

        public DBGateway()
        {
            connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentResultResultManagementDbConnectionString"].ConnectionString);
            commandObj=new SqlCommand();
        }
    }
}