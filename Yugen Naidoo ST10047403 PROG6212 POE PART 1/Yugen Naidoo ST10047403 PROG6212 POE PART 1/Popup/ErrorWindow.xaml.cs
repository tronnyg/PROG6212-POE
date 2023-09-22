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

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Popup
{
    /// <summary>
    /// Interaction logic for ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : UserControl
    {
        public ErrorWindow(string msg)
        {
            InitializeComponent();
            errorlabel.Text = msg;
        }

        internal Core.MainViewModel MainViewModel
        {
            get => default;
            set
            {
            }
        }
    }
}
