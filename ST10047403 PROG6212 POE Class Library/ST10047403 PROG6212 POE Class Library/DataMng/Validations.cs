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
    }
}
