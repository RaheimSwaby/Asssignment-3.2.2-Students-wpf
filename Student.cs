using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_proj
{
    public enum Month { Jan, Feb, Mar, Apr, May, jun, Jul, Aug, Sep, Oct, Nov, Dec }
    public enum Grades { A, B, C, D,F }
    public class Student
    {
        public int studentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public Grades Grade { get; set; }
       
        public static void AddStudent(Student student) 
        {
            Datasource.students.Add(student);
        }
        

    }
}
