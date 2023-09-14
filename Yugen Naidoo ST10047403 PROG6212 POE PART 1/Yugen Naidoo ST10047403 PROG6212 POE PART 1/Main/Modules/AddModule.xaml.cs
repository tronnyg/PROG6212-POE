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
using Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions;

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Modules
{
    /// <summary>
    /// Interaction logic for AddModule.xaml
    /// </summary>
    public partial class AddModule : UserControl
    {
        public AddModule()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public static implicit operator AddModule(AddSession v)
        {
            throw new NotImplementedException();
        }
    }
}
