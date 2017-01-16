using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskRecordKeerApp.Model
{
    public class TaskSalf
    {
         public TaskSalf(int id, string title, string startTime, string endTime, string date, int categoryId) : this(title, startTime, endTime, date, categoryId)
        {
            Id = id;
        }
        public TaskSalf(string title, string startTime, string endTime, string date, int categoryId)
        {
            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            Date = date;
            CategoryId = categoryId;
        }

        public TaskSalf(int id,string date)
        {
            Id = id;
            Date = date;
        }

        
        public string Title { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Date { get; set; }
        public int Id { get; set; }
        public int CategoryId { get; set; }

        public TaskSalf()
        {
            
        }
    }
}