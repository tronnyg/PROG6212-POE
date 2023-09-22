using ST10047403_PROG6212_POE_Class_Library;
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

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions
{
    /// <summary>
    /// Interaction logic for SessionsList.xaml
    /// </summary>
    public partial class SessionsList : UserControl
    {
        public SessionsList()
        {
            InitializeComponent();
            
        }

        internal MainViewModel MainViewModel
        {
            get => default;
            set
            {
            }
        }

        private void AddSessionButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SessionsListDatagrid.ItemsSource = null;
            SessionsListDatagrid.ItemsSource = CurrentUser.currentUser.Sessions1;
        }
    }
}
