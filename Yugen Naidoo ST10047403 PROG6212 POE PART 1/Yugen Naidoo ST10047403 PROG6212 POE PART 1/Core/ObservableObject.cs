using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core
{
    // Base class for implementing the INotifyPropertyChanged interface
    class ObservableObject : INotifyPropertyChanged
    {
        // Event that is raised when a property value changes
        public event PropertyChangedEventHandler PropertyChanged;

        // Method to raise the PropertyChanged event
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            // Invoke the event and pass the name of the property that changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
