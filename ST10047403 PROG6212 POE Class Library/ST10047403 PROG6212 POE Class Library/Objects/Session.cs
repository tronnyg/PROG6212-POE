using System;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Session
    {
        // ==== ATTRIBUTES === //
        private string sessionName;
        private string sessionModule;
        private string sessionNotes;
        private int sessionWeek;
        private DateTime sessionDate;
        private double sessionMinutes;
        // ================== //

        // ==== CONSTRUCTOR === //
        public Session(string sessionName, string sessionModule, string sessionNotes, DateTime sessionDate, double sessionMinutes, int sessionWeek)
        {
            this.SessionName = sessionName;
            this.SessionModule = sessionModule;
            this.SessionNotes = sessionNotes;
            this.SessionDate = sessionDate;
            this.SessionMinutes = sessionMinutes;
            this.SessionWeek = sessionWeek;
        }
        // ================== //

        // ==== GETTERS AND SETTERS === //
        public string SessionName { get => sessionName; set => sessionName = value; }
        public string SessionModule { get => sessionModule; set => sessionModule = value; }
        public string SessionNotes { get => sessionNotes; set => sessionNotes = value; }
        public DateTime SessionDate { get => sessionDate; set => sessionDate = value; }
        public double SessionMinutes { get => sessionMinutes; set => sessionMinutes = value; }
        public int SessionWeek { get => sessionWeek; set => sessionWeek = value; }
        // ================== //
    }
}
//======================================== END ========================================//