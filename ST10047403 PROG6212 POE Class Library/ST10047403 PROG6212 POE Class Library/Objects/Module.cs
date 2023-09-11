using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Module
    {
        private string moduleCode;
        private string moduleName;
        private string lecturerName;
        private int moduleCredits;
        private int moduleClassHours;
        private double moduleSelfStudyHours;

        public Module(string moduleCode, string moduleName, string lecturerName, int moduleCredits, int moduleClassHours, double moduleSelfStudyHours)
        {
            this.ModuleCode = moduleCode;
            this.ModuleName = moduleName;
            this.LecturerName = lecturerName;
            this.ModuleCredits = moduleCredits;
            this.ModuleClassHours = moduleClassHours;
            this.ModuleSelfStudyHours = moduleSelfStudyHours;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string LecturerName { get => lecturerName; set => lecturerName = value; }
        public int ModuleCredits { get => moduleCredits; set => moduleCredits = value; }
        public int ModuleClassHours { get => moduleClassHours; set => moduleClassHours = value; }
        public double ModuleSelfStudyHours { get => moduleSelfStudyHours; set => moduleSelfStudyHours = value; }
    }
}
