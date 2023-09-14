using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand SwitchToModulesCommand { get; set; }
        public RelayCommand SwitchToSessionsCommand { get; set; }
        public RelayCommand SwitchToAddModulesCommand { get; set; }
        public RelayCommand SwitchToAddSessionsCommand { get; set; }

        public ModuleList ModuleList { get; set; }
        public ModuleList SessionsList { get; set; }
        public AddModule AddModule { get; set; }
        public AddModule AddSession { get; set; }

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

            SwitchToModulesCommand = new RelayCommand(o =>
            {
                CurrentView = ModuleList;
            });

            SwitchToAddModulesCommand = new RelayCommand(o =>
            {
                CurrentView = AddModule;
            });

            SwitchToSessionsCommand = new RelayCommand(o =>
            {
                CurrentView = SessionsList;
            });

            SwitchToAddSessionsCommand = new RelayCommand(o =>
            {
                CurrentView = AddSession;
            });
        }
    }
}
