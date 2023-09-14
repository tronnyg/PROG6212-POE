using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Core;
using ST10047403_PROG6212_POE_Class_Library;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurrentUser.currentUser.Modules1.Add(new Module("PROG6212", "Programming 2B", "Ishmael", 15, 5, 5));
            CurrentUser.currentUser.Sessions1.Add(new Session("session1", "PROG6212", "", DateTime.Now, 60));
            Updates.updateModuleData(CurrentUser.currentUser);
        }
    }
}
