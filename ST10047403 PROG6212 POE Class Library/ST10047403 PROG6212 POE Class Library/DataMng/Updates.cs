using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public static class Updates
    {

       public static void updateModuleData(Student currentUser)
        {
            foreach (Session session in currentUser.Sessions1)
            {
                var matchingModule = currentUser.Modules1.FirstOrDefault(Module => Module.ModuleCode == session.SessionModule);

                if (matchingModule != null) 
                {
                    matchingModule.ModuleSelfStudyHours -= (session.SessionMinutes / 60);
                }
            }
        }

        public static void checkForWeekEnd(DateTime startDate, Student currentUser)
        {
            TimeSpan difference = DateTime.Now - startDate;
            if (difference.Days % 7 == 0) 
            {
                foreach (Module module in currentUser.Modules1)
                {
                    module.resetSelfStudyHours();
                    
                }
            }
        }
    }
}
