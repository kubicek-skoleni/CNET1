using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

using ConsoleApp.Model;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        Student editovany_student = new Student();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // 1. jmeno:
            editovany_student.Name = txtName.Text;

            // 2. datum narozeni
            // precit hodnotu z komponenty
            var zadane_datum = dateBirth.SelectedDate;
            // priradit do studenta + prevod z Datetime na DateOnly
            editovany_student.BirthDate = 
                DateOnly.FromDateTime(zadane_datum.Value);

            // 3. pohlavi
            var selected_index = cmbGender.SelectedIndex;
            editovany_student.Gender = (Gender)selected_index;

            // ulož do souboru
            File.WriteAllText("student.txt",
                                editovany_student.StringInfo());
        }
    }
}
