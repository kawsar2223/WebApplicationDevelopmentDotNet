using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskRecordKeerApp.DAL;
using TaskRecordKeerApp.Model;

namespace TaskRecordKeerApp.BLL
{
    public class TaskManager
    {
        TaskGatway tasksGetway = new TaskGatway();

        public string Save(TaskSalf taskSalf)
        {
            string message = "";
            int rowAffected = tasksGetway.Insert(taskSalf);
            if (rowAffected > 0)
            {
                message = "Save Successfully..!";
            }
            else
            {
                message = "Insertion failed..!";
            }
            return message;
        }

        public List<TaskSalf> ShowTaskses(string date)
        {
            return tasksGetway.ShowTaskses(date);
        }

        public List<TaskSalf> GetAllTaskses()
        {
            List<TaskSalf> taskses = tasksGetway.GetAllTaskses();
            return taskses;
        }

        public List<TaskSalf> GetAllDate()
        {
            return tasksGetway.GetAllDate();
        }
    }
}