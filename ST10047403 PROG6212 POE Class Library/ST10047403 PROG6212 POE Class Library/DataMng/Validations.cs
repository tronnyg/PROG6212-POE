using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10047403_PROG6212_POE_Class_Library
{
    public class Validations
    {
      private Dictionary<int,string> errorMessage = new Dictionary<int, string>();

        public Validations()
        {
            errorMessage.Add(0, "Field cannot be blank");
            errorMessage.Add(1, "Incorrect Format");
            errorMessage.Add(2, "Please enter a valid number");
            errorMessage.Add(3, "Selected date cannot be in future");
            errorMessage.Add(4, "Selected date cannot be in the past");
        }

        public string getError(int input)
        {
            return errorMessage[input];
        }

        public bool isBlank(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public bool isAnInt(string input)
        {
            return int.TryParse(input,out int value);
        }

        public bool isADouble(string input)
        {
            return double.TryParse(input,out double value);
        }

        public bool isDateInFuture(DateTime input)
        {
            if (input > DateTime.Now)
            { return true; }
            else { return false; }
        }

        public bool isDateInPast(DateTime input)
        {
            if (input < DateTime.Now)
            { return true; }
            else { return false; }
        }

        public bool isDateInBetween(DateTime input, DateTime startDate, DateTime endDate)
        {
            return input >= startDate && input <= endDate;
        }

    }
}
//======================================== END ========================================//