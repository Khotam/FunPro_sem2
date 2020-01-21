using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiut
{
    class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public string MaritalStatus { get; set; }
        public string PassportNo { get; set; }
        public Course Course { get; set; }


        public Applicant(string name, string surname, string address, DateTime doB, string maritalStatus, string passportNo, Course course)
        {
            Name = name;
            Surname = surname;
            Address = address;
            DoB = doB;
            MaritalStatus = maritalStatus;
            PassportNo = passportNo;
            Course = course;
        }
    }
}
