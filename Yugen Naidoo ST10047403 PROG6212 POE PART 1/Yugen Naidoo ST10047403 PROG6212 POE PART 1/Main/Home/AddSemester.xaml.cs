using ST10047403_PROG6212_POE_Class_Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
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

namespace Yugen_Naidoo_ST10047403_PROG6212_POE_PART_1.Main.Home
{
    /// <summary>
    /// Interaction logic for AddSemester.xaml
    /// </summary>
    public partial class AddSemester : UserControl
    {
        DateTime? semesterStartDate = null;
        int? semesterLength = null;
        Validations newVal = new Validations();

        public AddSemester()
        {
            InitializeComponent();
            FinishButton.IsEnabled = false;
            
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
            CurrentUser.semesterStartDate = semesterStartDate.Value;
            CurrentUser.numWeeks = semesterLength.Value;
            CurrentUser.semesterAdded = true;
        }

        private void StartDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (newVal.isDateInPast((DateTime)StartDatePicker.SelectedDate))
            {
                StartDateErrorLabel.Text = "Date cannot be in the past";
                StartDateErrorLabel.Visibility = Visibility.Visible;
                semesterStartDate = null;
            }
            else if (newVal.isBlank(StartDatePicker.SelectedDate.ToString()))
            {
                StartDateErrorLabel.Text = "Date cannot be blank";
                StartDateErrorLabel.Visibility = Visibility.Visible;
                semesterStartDate = null;
            }
            else
            {
                StartDateErrorLabel.Visibility = Visibility.Collapsed;
                semesterStartDate = (DateTime)StartDatePicker.SelectedDate;

            }

            CheckIfValid();
        }

        private void SemesterLengthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = FindTextBoxInTemplate(SemesterLengthTextBox);

            if (newVal.isAnInt(textBox.Text))
            {
                SemesterLengthErrorLabel.Visibility = Visibility.Collapsed;
                semesterLength = int.Parse(textBox.Text);
            }
            else if (newVal.isBlank(textBox.Text))
            {
                SemesterLengthErrorLabel.Text = "Cannot be blank";
                SemesterLengthErrorLabel.Visibility = Visibility.Visible;
                semesterLength = null;
            }
            else
            {   
                SemesterLengthErrorLabel.Text = "Please enter a valid number";
                SemesterLengthErrorLabel.Visibility = Visibility.Visible;
                semesterLength = null;
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
            if (semesterStartDate == null || semesterLength == null)
            {
                FinishButton.IsEnabled = false;
            }
            else
            {
                FinishButton.IsEnabled = true;
            }
        }
    }
}
