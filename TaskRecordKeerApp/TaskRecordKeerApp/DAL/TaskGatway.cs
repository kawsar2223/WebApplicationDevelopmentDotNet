using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using TaskRecordKeerApp.Model;

namespace TaskRecordKeerApp.DAL
{
    public class TaskGatway
    {

         string connectionString = WebConfigurationManager.ConnectionStrings["TasksConString"].ConnectionString;

        public int Insert(TaskSalf taskSalf)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //string query = "INSERT INTO Tasks(Title,StartTime,EndTime,Date,CategoryId) VALUES(@Title , @StartTime , @EndTime , @Date,'" + tasks.CategoryId+ "')";
            string query = "INSERT INTO TaskSalf(Title,StartTime,EndTime,Date,CategoryId) VALUES('" + taskSalf.Title + "','" + taskSalf.StartTime + "','" + taskSalf.EndTime + "','" + taskSalf.Date + "','" + taskSalf.CategoryId + "')";
            SqlCommand command = new SqlCommand(query,connection);

           /* command.Parameters.Clear();
            command.Parameters.Add("Title", SqlDbType.VarChar);
            command.Parameters["Title"].Value = tasks.Title;
            command.Parameters.Add("StartTime", SqlDbType.VarChar);
            command.Parameters["StartTime"].Value = tasks.StartTime;
            command.Parameters.Add("EndTime", SqlDbType.VarChar);
            command.Parameters["EndTime"].Value = tasks.EndTime;
            command.Parameters.Add("Date", SqlDbType.VarChar);
            command.Parameters["Date"].Value = tasks.Date;*/
            


            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public List<TaskSalf> ShowTaskses(string search)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Title,StartTime,EndTime,Date FROM TaskSalf WHERE Date='" + search + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            List<TaskSalf> taskses = new List<TaskSalf>();
            SqlDataReader reader = command.ExecuteReader();
            TaskSalf taskSalf = null;
            while (reader.Read())
            {
                taskSalf = new TaskSalf();
                
                taskSalf.Title = reader["Title"].ToString();
                taskSalf.StartTime = reader["StartTime"].ToString();
                taskSalf.EndTime = reader["EndTime"].ToString();
                taskSalf.Date = reader["Date"].ToString();
                taskses.Add(taskSalf);
            }
            reader.Close();
            connection.Close();
            return taskses;
        }

        public List<TaskSalf> GetAllTaskses()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT Title,StartTime,EndTime FROM TaskSalf";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<TaskSalf> taskses = new List<TaskSalf>();
            while (reader.Read())
            {
                TaskSalf taskSalf = new TaskSalf();
                taskSalf.Title = reader["Title"].ToString();
                taskSalf.StartTime = reader["StartTime"].ToString();
                taskSalf.EndTime = reader["EndTime"].ToString();
                taskses.Add(taskSalf);

            }
            reader.Close();
            connection.Close();
            return taskses;
        }

        public List<TaskSalf> GetAllDate()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM TaskSalf";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<TaskSalf> taskses = new List<TaskSalf>();
            while (reader.Read())
            {
                TaskSalf taskSalf = new TaskSalf();
                taskSalf.Date = reader["Date"].ToString();
                taskSalf.Id = Convert.ToInt32(reader["Id"].ToString());
                taskses.Add(taskSalf);
            }
            reader.Close();
            connection.Close();
            return taskses;
        }
 
    }

    }
