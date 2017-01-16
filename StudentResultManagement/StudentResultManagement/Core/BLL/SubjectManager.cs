using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentResultManagement.Core.Gateway;
using StudentResultManagement.Models;

namespace StudentResultManagement.Core.BLL
{
    public class SubjectManager
    {
        SubjectGateway subjectGateway=new SubjectGateway();
        public IEnumerable<Subject> GetAll
        {
            get { return subjectGateway.GetAll;}
        }
    }
}