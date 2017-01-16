using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentResultManagement.Models;

namespace StudentResultManagement.Core.Gateway
{
    public class StudentResultGateway:DBGateway
    {
        public int Insert(StudentResult studentResult)
        {
            CommandObj.CommandText = "INSERT INTO t_StudentResult VALUES(@regNo,@subjectid,@score)";
            CommandObj.Parameters.Clear();
            CommandObj.Parameters.AddWithValue("regNo", studentResult.RegistrationNo);
            CommandObj.Parameters.AddWithValue("@subjectid", studentResult.SubjectId);
            CommandObj.Parameters.AddWithValue("@score", studentResult.Score);
            ConnectionObj.Open();
            int rowaffectd = CommandObj.ExecuteNonQuery();
            CommandObj.Dispose();
            ConnectionObj.Close();
            return rowaffectd;
        }

        public IEnumerable<StudentResult> GetAllResults
        {
            get
            {
                List<StudentResult> studentResults=new List<StudentResult>();
                CommandObj.CommandText = "SELECT * FROM t_StudentResult";
                ConnectionObj.Open();
                SqlDataReader reader = CommandObj.ExecuteReader();
                while (reader.Read())
                {
                    StudentResult studentResult=new StudentResult
                    {
                        Id = Convert.ToInt32(reader["Id"].ToString()),
                        SubjectId = Convert.ToInt32(reader["SubjectId"].ToString()),
                        RegistrationNo = reader["RegNo"].ToString(),
                        Score = Convert.ToDouble(reader["Score"].ToString())
                    };
                    studentResults.Add(studentResult);
                }
                reader.Close();
                CommandObj.Dispose();
                ConnectionObj.Close();
                return studentResults;
            }
        }

        public IEnumerable<ViewStudentResult> GetViewStudentResult
        {
            get
            {

                List<ViewStudentResult> studentResults = new List<ViewStudentResult>();
                CommandObj.CommandText = "spVieStudentResult";
                CommandObj.CommandType = CommandType.StoredProcedure;
                ConnectionObj.Open();
                SqlDataReader reader = CommandObj.ExecuteReader();
                while (reader.Read())
                {
                    ViewStudentResult studentResult = new ViewStudentResult
                    {
                       RegistrationNo = reader["RegNo"].ToString(),
                       Subject = reader["Name"].ToString(),
                        Score = Convert.ToDouble(reader["Score"].ToString())
                    };
                    studentResults.Add(studentResult);
                }
                reader.Close();
                CommandObj.Dispose();
                ConnectionObj.Close();
                return studentResults;
            }
        }
    }
}