using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Home;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Popup;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand SwitchToModulesCommand { get; set; }
        public RelayCommand SwitchToSessionsCommand { get; set; }
        public RelayCommand SwitchToAddModulesCommand { get; set; }
        public RelayCommand SwitchToAddSessionsCommand { get; set; }
        public RelayCommand SwitchToAddSemesterCommand { get; set; }

        public ModuleList ModuleList { get; set; }
        public SessionsList SessionsList { get; set; }
        public AddModule AddModule { get; set; }
        public AddSession AddSession { get; set; }
        public AddSemester AddSemester { get; set; }

        public ErrorWindow ErrorWindow { get; set; } 

        private object _currentView;


        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        {
            ModuleList = new ModuleList();
            AddModule = new AddModule();
            AddSession = new AddSession();
            SessionsList = new SessionsList();
            AddSemester = new AddSemester();

            SwitchToModulesCommand = new RelayCommand(o =>
            {
                if (!CurrentUser.semesterAdded)
                {
                    ErrorWindow = new ErrorWindow("Please add a semester first");
                    CurrentView = ErrorWindow;
                }
                else 
                { CurrentView = ModuleList; }
                
            });

            SwitchToAddModulesCommand = new RelayCommand(o =>
            {
                CurrentView = AddModule;
            });

            SwitchToSessionsCommand = new RelayCommand(o =>
            {
                if (!CurrentUser.moduleAdded)
                {
                    ErrorWindow = new ErrorWindow("Please add a module first");
                    CurrentView = ErrorWindow;
                }
                else
                { CurrentView = SessionsList; }
                
            });

            SwitchToAddSessionsCommand = new RelayCommand(o =>
            {
                CurrentView = AddSession;
            });

            SwitchToAddSemesterCommand = new RelayCommand(o =>
            {
                if (CurrentUser.semesterAdded)
                {
                    ErrorWindow = new ErrorWindow("You can only add one semester");
                    CurrentView = ErrorWindow;
                }
                else
                { CurrentView = AddSemester; }
            });
        }
    }
}
