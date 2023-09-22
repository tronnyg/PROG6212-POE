using System;
using System.Collections.Generic;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Module
    {
        // ==== ATTRIBUTES === //
        private string moduleCode;
        private string moduleName;
        private int moduleLength;
        private string lecturerName;
        private int moduleCredits;
        private int moduleClassHours;
        private double moduleSelfStudyHours;
        private double moduleSelfStudyHoursRemaining;
        // ================== //

        // ==== CONSTRUCTOR === //
        public Module(string moduleCode, string moduleName, string lecturerName, int moduleCredits, int moduleClassHours, int moduleLength)
        {
            this.ModuleCode = moduleCode;
            this.ModuleName = moduleName;
            this.LecturerName = lecturerName;
            this.ModuleCredits = moduleCredits;
            this.ModuleClassHours = moduleClassHours;
            this.ModuleLength = moduleLength;
            this.ModuleSelfStudyHours = selfStudyHours();
            this.ModuleSelfStudyHoursRemaining = this.ModuleSelfStudyHours;
        }
        // ================== //

        // ==== GETTERS AND SETTERS === //
        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string LecturerName { get => lecturerName; set => lecturerName = value; }
        public int ModuleCredits { get => moduleCredits; set => moduleCredits = value; }
        public int ModuleClassHours { get => moduleClassHours; set => moduleClassHours = value; }
        public int ModuleLength { get => moduleLength; set => moduleLength = value; }
        public double ModuleSelfStudyHours { get => moduleSelfStudyHours; set => moduleSelfStudyHours = value; }
        public double ModuleSelfStudyHoursRemaining { get => moduleSelfStudyHoursRemaining; set => moduleSelfStudyHoursRemaining = value; }
        // ================== //

        // CALCULATE SELF STUDY HOURS //
        public double selfStudyHours()
        {
            return ((moduleCredits * 10) / moduleLength) - moduleClassHours;
        }

        // RESET REMAINING SELF STUDY HOURS //
        public void resetSelfStudyHours()
        {
            this.ModuleSelfStudyHoursRemaining = selfStudyHours();
        }

        // CALCULATE REMAINING SELF STUDY HOURS //
        public void calcRemainingStudyHours(List<Session> sessionsList, int week)
        {
            resetSelfStudyHours();
            foreach (Session session in sessionsList) 
            {
                if (session.SessionWeek == week)
                {
                    if (session.SessionModule == this.ModuleCode)
                    {
                        ModuleSelfStudyHoursRemaining -= (session.SessionMinutes / 60);
                    }
                }
            }
        }

    }
}
//======================================== END ========================================//