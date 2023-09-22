using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public static class Updates
    {
        public static DateTime weekStartDate = new DateTime();
        public static int numWeeks = 0;


        // Updates the study hours for modules of the current user for a given week //
        public static void updateModuleData(Student currentUser, int week)
        {
            foreach (Module module in currentUser.Modules)
            {
                module.calcRemainingStudyHours(currentUser.Sessions, week);
            }
        }
        // ======================================================================= //

        // Calculates the current week of the semester based on start date, total weeks, and current date //
        public static int CalculateWeekOfSemester(DateTime semesterStartDate, int totalWeeks, DateTime currentDate)
        {
            // Calculate the number of days between the semester start date and the current date
            TimeSpan timeSpan = currentDate - semesterStartDate;

            // Calculate the number of weeks by dividing the total days by 7
            int weeks = (int)Math.Ceiling(timeSpan.TotalDays / 7);

            // Ensure the result is within the valid range of 1 to totalWeeks
            if (weeks < 1)
            {
                return 1;
            }
            else if (weeks > totalWeeks)
            {
                return totalWeeks;
            }
            else
            {
                return weeks;
            }
        }
        // ======================================================================= //

    }
}
//======================================== END ========================================//