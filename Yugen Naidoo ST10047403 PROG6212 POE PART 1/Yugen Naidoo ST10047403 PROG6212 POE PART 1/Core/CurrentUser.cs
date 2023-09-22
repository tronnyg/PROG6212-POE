using ST10047403_PROG6212_POE_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Home;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core
{
    public static class CurrentUser

    {   // Check if semester and module added //
        public static bool semesterAdded = false;
        public static bool moduleAdded = false;

        // Semester Details //
        public static DateTime semesterStartDate = DateTime.Now;
        public static int numWeeks = 0;
        public static DateTime semesterEndDate
        {
            get
            {
                return semesterStartDate.AddDays(numWeeks * 7);
            }
        }

        // Current user date //
        public static Student currentUser = new Student("user1", "pass1", "Yugen", "Naidoo", "st10047403");

    }
}
