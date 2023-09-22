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
    /// Interaction logic for AddModule.xaml
    /// </summary>
    public partial class AddModule : UserControl
    {
        //==== TEMP VARIABLES ====//
        Validations newVal = new Validations();
        string moduleCode = null;
        string moduleName = null;
        string moduleCredits = null;
        string moduleClassHours = null;
        string lecturerName = null;
        public AddModule()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.currentUser.Modules1.Add(new Module(moduleCode,moduleName,lecturerName,int.Parse(moduleCredits),int.Parse(moduleClassHours),CurrentUser.numWeeks));
            CurrentUser.moduleAdded = true;
        }

        private void ModuleCodeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = FindTextBoxInTemplate(ModuleCodeTextBox);
            if (newVal.isBlank(textbox.Text))
            {
                ModuleCodeErrorLabel.Text = "Cannot be Empty";
                ModuleCodeErrorLabel.Visibility = Visibility.Visible;
                moduleCode = null;
            }
            else
            {
                ModuleCodeErrorLabel.Visibility =Visibility.Collapsed;
                moduleCode = textbox.Text;
            }
            CheckIfValid();
        }

        private void ModuleNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = FindTextBoxInTemplate(ModuleNameTextBox);
            if (newVal.isBlank(textbox.Text))
            {
                ModuleNameErrorLabel.Text = "Cannot be Empty";
                ModuleNameErrorLabel.Visibility = Visibility.Visible;
                moduleCode = null;
            }
            else
            {
                ModuleNameErrorLabel.Visibility = Visibility.Collapsed;
                moduleName = textbox.Text;
            }
            CheckIfValid();
        }

        private void CreditsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = FindTextBoxInTemplate(CreditsTextBox);
            if (newVal.isBlank(textbox.Text))
            {
                CreditsErrorLabel.Text = "Cannot be Empty";
                CreditsErrorLabel.Visibility = Visibility.Visible;
                moduleCredits = null;
            }
            else if (!newVal.isAnInt(textbox.Text))
            {
                CreditsErrorLabel.Text = "Please enter a number";
                CreditsErrorLabel.Visibility = Visibility.Visible;
                moduleCredits = null;
            }
            else
            {
                CreditsErrorLabel.Visibility = Visibility.Collapsed;
                moduleCredits = textbox.Text;
            }
            CheckIfValid();
        }

        private void ClassHoursTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = FindTextBoxInTemplate(ClassHoursTextBox);
            if (newVal.isBlank(textbox.Text))
            {
                ClassHoursErrorLabel.Text = "Cannot be Empty";
                ClassHoursErrorLabel.Visibility = Visibility.Visible;
                moduleClassHours = null;
            }
            else if (!newVal.isAnInt(textbox.Text))
            {
                ClassHoursErrorLabel.Text = "Please enter a number";
                ClassHoursErrorLabel.Visibility = Visibility.Visible;
                moduleClassHours = null;
            }
            else
            {
                ClassHoursErrorLabel.Visibility = Visibility.Collapsed;
                moduleClassHours = textbox.Text;
            }
            CheckIfValid();
        }


        private TextBox FindTextBoxInTemplate(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBox textBox)
                {
                    return textBox;
                }

                TextBox foundTextBox = FindTextBoxInTemplate(child);

                if (foundTextBox != null)
                {
                    return foundTextBox;
                }
            }

            return null;
        }

        private void CheckIfValid()
        {
            if (moduleCode != null && moduleName != null && moduleCredits != null && moduleClassHours != null)
            {
                FinishButton.IsEnabled = true;
            }
            else
            {
                FinishButton.IsEnabled = false;
            }
        }

        private void ClearTextBoxes(DependencyObject parent)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                if (child is TextBox textBox)
                {
                    textBox.Clear(); // Clear the text from the TextBox
                }

                ClearTextBoxes(child); // Recursively check child elements
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes(this);
            ModuleCodeErrorLabel.Visibility = Visibility.Collapsed;
            ModuleNameErrorLabel.Visibility = Visibility.Collapsed;
            CreditsErrorLabel.Visibility = Visibility.Collapsed;
            ClassHoursErrorLabel.Visibility = Visibility.Collapsed;

        }
    }
}
