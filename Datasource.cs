using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_proj
{
     public static class Datasource
    {
        public static List<Student> students { get; set; } = new List<Student>(); 

        // this is to populate the data of the list
        public static void AddStudent() 
        {
            students.Add( new Student {Name = " Raheim", LastName= "Swaby", Address= "Miami", studentId =2345, Grade = Grades.B , MonthOfAdmission = Month.Mar });

            students.Add(new Student { Name = " John", LastName = "Nane", Address = "something BLVD", studentId = 2345, Grade = Grades.C, MonthOfAdmission = Month.May });
            students.Add(new Student { Name = " Richard", LastName = "Peebody", Address = "NA BLVD", studentId = 4546, Grade = Grades.F, MonthOfAdmission = Month.Jan });
            students.Add(new Student { Name = "Rigby", LastName = "Smalls", Address = "something st", studentId = 6788, Grade = Grades.B, MonthOfAdmission = Month.jun });

        }


    }
}
