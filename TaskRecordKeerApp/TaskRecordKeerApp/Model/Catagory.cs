using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskRecordKeerApp.Model
{
    public class Catagory
    {
         public Catagory(string name)
        {
            Name = name;
        }

        public Catagory()
        {
            
        }

        public string Name { get; set; }
        public int Id { get; set; }
        
    }
}