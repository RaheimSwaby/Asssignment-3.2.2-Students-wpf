using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace student_proj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Datasource.AddStudent();
           StudentDataGrid.ItemsSource = Datasource.students;
            
            

        }

        private void RemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)StudentDataGrid.SelectedItem;
            if (selectedStudent != null)
            {
                Datasource.students.Remove(selectedStudent);
                StudentDataGrid.Items.Refresh();
            }
            else 
            {
                MessageBox.Show("Please select a valid student to remove","No selection has been made", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            var newstudent = new Student
            {
                Name = "Enter A Name",
                studentId = 1,
                Address = "Enter Address",
                Grade = Grades.A,
                LastName = "Enter LastName",
                MonthOfAdmission = Month.jun,


            };

            Datasource.students.Add(newstudent);
            StudentDataGrid.Items.Refresh();
        }
    }
}