using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskRecordKeerApp.DAL;
using TaskRecordKeerApp.Model;

namespace TaskRecordKeerApp.BLL
{
    public class CatagoryManager
    {
        CatagoryGetway catagoryGetway = new CatagoryGetway();

        public string Save(Catagory catagory)
        {
            
            string message = "";

            
            int rowAffected = catagoryGetway.Insert(catagory);
            if (rowAffected > 0)
            {
                message = "Save Successfully..!";
            }
            else
            {
                message = "Insertion Failed..!";
            }
            return message;
        }

        public List<Catagory> GetAll()
        {
            return catagoryGetway.GetAll();
        } 

    }
}