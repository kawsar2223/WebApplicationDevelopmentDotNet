using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace StudentResultManagement.Models
{
    public class StudentResult
    {
        public int  Id { get; set; }
        [DisplayName("Registration No")]
        public string RegistrationNo { get; set; }
        [DisplayName("Subject")]
        public int SubjectId { get; set; }
        public double Score { get; set; }
    }
}