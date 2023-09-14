using ST10047403_PROG6212_POE_Class_Library.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Student: User
    {
        private string studentName;
        private string studentSurname;
        private string studentID;
        private List<Module> Modules = new List<Module>();
        private List<Session> Sessions = new List<Session>();
        private List<Event> Events = new List<Event>();

        public Student(string username, string password, string studentName, string studentSurname, string studentID) : base(username, password)
        {
            this.StudentName = studentName;
            this.StudentSurname = studentSurname;
            this.StudentID = studentID;
        }

        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public List<Module> Modules1 { get => Modules; set => Modules = value; }
        public List<Session> Sessions1 { get => Sessions; set => Sessions = value; }
        public List<Event> Events1 { get => Events; set => Events = value; }
    }
}
