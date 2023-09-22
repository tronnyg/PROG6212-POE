using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Event
    {
        // ==== ATTRIBUTES === //
        private string eventName;
        private string eventType;
        private string eventNotes;
        private string eventModule;
        private DateTime eventDate;
        // ================== //

        // ==== CONSTRUCTOR === //
        public Event(string eventName, string eventType, string eventNotes, string eventModule, DateTime eventDate)
        {
            this.EventName = eventName;
            this.EventType = eventType;
            this.EventNotes = eventNotes;
            this.EventModule = eventModule;
            this.EventDate = eventDate;
        }
        // ================== //

        // ==== GETTERS AND SETTERS === //
        public string EventName { get => eventName; set => eventName = value; }
        public string EventType { get => eventType; set => eventType = value; }
        public string EventNotes { get => eventNotes; set => eventNotes = value; }
        public string EventModule { get => eventModule; set => eventModule = value; }
        public DateTime EventDate { get => eventDate; set => eventDate = value; }
        // ================== //
    }
}
//======================================== END ========================================//