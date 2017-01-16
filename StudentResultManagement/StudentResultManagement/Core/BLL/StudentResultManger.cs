using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentResultManagement.Core.Gateway;
using StudentResultManagement.Models;

namespace StudentResultManagement.Core.BLL
{
    public class StudentResultManger
    {
        StudentResultGateway studentResultGateway=new StudentResultGateway();
        public string Save(StudentResult studentResult)
        {

            bool isResultEntrValid = GetStudentResultByRegNoAndsubjectId(studentResult.RegistrationNo,
                studentResult.SubjectId);
            if (isResultEntrValid)
            {
                if (studentResultGateway.Insert(studentResult) > 0)
                {
                    return "Save Sucessfully";
                }
                return "Failed to save";  
            }
            return "This result already Exits";
        }

        private bool GetStudentResultByRegNoAndsubjectId(string regNo, int subId)
        {
            var studentRsultList = studentResultGateway.GetAllResults.ToList();
            StudentResult result = studentRsultList.Find(st => st.RegistrationNo == regNo && st.SubjectId == subId);
            if (result == null)
            {
                return true;

            }
            return false;
        }

        public IEnumerable<StudentResult> GStudentResultByRegNo(string regNo)
        {
            List<StudentResult> studentResults =
                studentResultGateway.GetAllResults.ToList().FindAll(stReg => stReg.RegistrationNo == regNo);
            return studentResults;
        }

        public IEnumerable<ViewStudentResult> GetStudentResults
        {
            get { return studentResultGateway.GetViewStudentResult; }
        } 
    }
}