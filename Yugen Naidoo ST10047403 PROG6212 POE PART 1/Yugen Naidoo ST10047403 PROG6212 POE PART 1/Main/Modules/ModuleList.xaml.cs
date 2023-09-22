using ST10047403_PROG6212_POE_Class_Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules
{
    /// <summary>
    /// Interaction logic for ModuleList.xaml
    /// </summary>
    public partial class ModuleList : UserControl
    {
        public ModuleList()
        {
            InitializeComponent();
            ModuleListDatagrid.ItemsSource = CurrentUser.currentUser.Modules1;
        }

        private void AddModuleButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ModuleListDatagrid.ItemsSource = null;
            ModuleListDatagrid.ItemsSource = CurrentUser.currentUser.Modules1;
            if (SemesterWeeksComboBox.Items.Count == 0)
            {
                for (int i = 0; i < CurrentUser.numWeeks; i++)
                {
                    SemesterWeeksComboBox.Items.Add("Week " + (i + 1));
                }
            }
        }

        private void SemesterWeeksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   
            if (CurrentUser.currentUser.Sessions1.Count != 0)
            {
                Updates.updateModuleData(CurrentUser.currentUser,(SemesterWeeksComboBox.SelectedIndex+1));
                ModuleListDatagrid.ItemsSource = null;
                ModuleListDatagrid.ItemsSource = CurrentUser.currentUser.Modules1;
            }

        }
    }
}
