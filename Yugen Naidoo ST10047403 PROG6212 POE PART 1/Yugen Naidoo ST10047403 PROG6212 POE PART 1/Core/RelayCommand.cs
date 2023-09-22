using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core
{
    // Implementation of the ICommand interface for a basic RelayCommand
    class RelayCommand : ICommand
    {
        private Action<object> _execute;             // The action to be executed
        private Func<object, bool> _canExecute;      // The function to determine if the action can be executed

        // Event that is raised when the ability to execute the command changes
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }

        // Constructor for RelayCommand
        public RelayCommand(Action<Object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        internal MainViewModel MainViewModel
        {
            get => default;
            set
            {
            }
        }

        // Determines if the command can be executed
        public bool CanExecute(object parameter)
        {
            // If a canExecute function is provided, invoke it with the parameter
            // Otherwise, assume the command can always be executed
            return _canExecute == null || _canExecute(parameter);
        }

        // Executes the command
        public void Execute(object parameter)
        {
            // Execute the action with the parameter
            _execute(parameter);
        }
    }
}
