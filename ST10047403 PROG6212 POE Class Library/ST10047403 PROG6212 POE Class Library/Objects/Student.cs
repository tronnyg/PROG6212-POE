using ST10047403_PROG6212_POE_Class_Library.Objects;
using System;
using System.Collections.Generic;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Student : User
    {
        // ==== ATTRIBUTES === //
        private string studentName;
        private string studentSurname;
        private string studentID;
        private List<Module> modules = new List<Module>();
        private List<Session> sessions = new List<Session>();
        private List<Event> events = new List<Event>();
        // ================== //

        // ==== CONSTRUCTOR === //
        public Student(string username, string password, string studentName, string studentSurname, string studentID)
            : base(username, password)
        {
            this.StudentName = studentName;
            this.StudentSurname = studentSurname;
            this.StudentID = studentID;
        }
        // ================== //

        // ==== GETTERS AND SETTERS === //
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public List<Module> Modules { get => modules; set => modules = value; }
        public List<Session> Sessions { get => sessions; set => sessions = value; }
        public List<Event> Events { get => events; set => events = value; }
        // ================== //
    }
}
//======================================== END ========================================//