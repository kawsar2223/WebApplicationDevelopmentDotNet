using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentResultManagement.Models;

namespace StudentResultManagement.Core.Gateway
{
    public class SubjectGateway:DBGateway
    {
        public IEnumerable<Subject> GetAll
        {
            get
            {
                List<Subject> subjects = new List<Subject>();
                CommandObj.CommandText = "SELECT * FROM t_Subject";
                ConnectionObj.Open();
                SqlDataReader reader = CommandObj.ExecuteReader();
                while (reader.Read())
                {
                    Subject subject=new Subject
                    {
                        Id = Convert.ToInt32(reader["Id"].ToString()),
                        Name = reader["Name"].ToString()
                    };
                    subjects.Add(subject);
                }
                reader.Close();
                ConnectionObj.Close();
                CommandObj.Dispose();
                return subjects;
            }
        } 
    }
}