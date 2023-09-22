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

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Sessions
{
    /// <summary>
    /// Interaction logic for AddSession.xaml
    /// </summary>
    public partial class AddSession : UserControl
    {
        Validations newVal = new Validations();
        DateTime? sessionDate = null;
        string sessionModule = null;
        string sessionName = null;
        double? sessionMinutes = null;
        public AddSession()
        {
            InitializeComponent();
            foreach (Module module in CurrentUser.currentUser.Modules1)
            {
                ModuleCodeComboBox.Items.Add(module.ModuleCode);
                ModuleCodeComboBox.SelectedIndex = 0;
            }

        }

        internal MainViewModel MainViewModel
        {
            get => default;
            set
            {
            }
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.currentUser.Sessions1.Add(new Session(sessionName,sessionModule,"",sessionDate.Value,sessionMinutes.Value,Updates.CalculateWeekOfSemester(CurrentUser.semesterStartDate,CurrentUser.numWeeks,sessionDate.Value)));
            
        }

        private void SessionDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (newVal.isBlank(SessionDatePicker.SelectedDate.ToString()))
            {
                SessionDateErrorLabel.Text = "Date cannot be blank";
                SessionDateErrorLabel.Visibility = Visibility.Visible;
                sessionDate = null;
            }
            else if (SessionDatePicker.SelectedDate < CurrentUser.semesterStartDate)
            {
                SessionDateErrorLabel.Text = "Date cannot be before semester starts";
                SessionDateErrorLabel.Visibility = Visibility.Visible;
                sessionDate = null;
            }
            else if (SessionDatePicker.SelectedDate < CurrentUser.semesterEndDate)
            {
                SessionDateErrorLabel.Text = "Date cannot be after semester ends";
                SessionDateErrorLabel.Visibility = Visibility.Visible;
                sessionDate = null;
            }
            else
            {
                SessionDateErrorLabel.Visibility = Visibility.Collapsed;
                sessionDate = (DateTime)SessionDatePicker.SelectedDate;

            }
            CheckIfValid();
        }

        private void SessionNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = FindTextBoxInTemplate(SessionNameTextBox);
            if (newVal.isBlank(textbox.Text))
            {
                SessionsNameErrorLabel.Text = "Cannot be Empty";
                SessionsNameErrorLabel.Visibility = Visibility.Visible;
                sessionName = null;
            }
            else
            {
                SessionsNameErrorLabel.Visibility = Visibility.Collapsed;
                sessionName = textbox.Text;
            }
            CheckIfValid();
        }

        private void ModuleCodeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (newVal.isBlank(ModuleCodeComboBox.SelectedValue.ToString()))
            {
                ModuleCodeErrorLabel.Text = "Please select a Module";
                ModuleCodeErrorLabel.Visibility = Visibility.Visible;
                sessionModule = null;
            }
            else
            {
                ModuleCodeErrorLabel.Visibility = Visibility.Collapsed;
                sessionModule = ModuleCodeComboBox.SelectedValue.ToString();
            }
            CheckIfValid();
        }

        private void SessionMinutesTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textbox = FindTextBoxInTemplate(SessionMinutesTextBox);
            if (newVal.isBlank(textbox.Text))
            {
                SessionMinutesErrorLabel.Text = "Cannot be Empty";
                SessionMinutesErrorLabel.Visibility = Visibility.Visible;
                sessionMinutes = null;
            }
            else if (!newVal.isADouble(textbox.Text))
            {
                SessionMinutesErrorLabel.Text = "Please enter a number";
                SessionMinutesErrorLabel.Visibility = Visibility.Visible;
                sessionMinutes = null;
            }
            else
            {
                SessionMinutesErrorLabel.Visibility = Visibility.Collapsed;
                sessionMinutes = int.Parse(textbox.Text);
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
            if (sessionDate != null && sessionName != null && sessionModule != null && sessionMinutes != null)
            {
                FinishButton.IsEnabled = true;
            }
            else
            {
                FinishButton.IsEnabled = false;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();
            foreach (Module module in CurrentUser.currentUser.Modules1)
            {
                list.Add(module.ModuleCode);
            }

            ModuleCodeComboBox.ItemsSource = list;
            
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
            SessionDatePicker.SelectedDate = null;
            ClearTextBoxes(this);
            SessionsNameErrorLabel.Visibility = Visibility.Collapsed;
            ModuleCodeErrorLabel.Visibility = Visibility.Collapsed;
            SessionDateErrorLabel.Visibility = Visibility.Collapsed;
            SessionMinutesErrorLabel.Visibility = Visibility.Collapsed;
        }
    }
}
