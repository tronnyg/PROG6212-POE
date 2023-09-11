using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Session
    {
        private string sessionName;
        private string sessionModule;
        private string sessionNotes;
        private DateTime sessionDate;
        private double sessionMinutes;

        public Session(string sessionName, string sessionModule, string sessionNotes, DateTime sessionDate, double sessionMinutes)
        {
            this.SessionName = sessionName;
            this.SessionModule = sessionModule;
            this.SessionNotes = sessionNotes;
            this.SessionDate = sessionDate;
            this.SessionMinutes = sessionMinutes;
        }

        public string SessionName { get => sessionName; set => sessionName = value; }
        public string SessionModule { get => sessionModule; set => sessionModule = value; }
        public string SessionNotes { get => sessionNotes; set => sessionNotes = value; }
        public DateTime SessionDate { get => sessionDate; set => sessionDate = value; }
        public double SessionMinutes { get => sessionMinutes; set => sessionMinutes = value; }
    }
}
