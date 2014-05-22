using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student kSmith = new Student();
            kSmith.Id = 1;
            kSmith.Name = "Stephen Harper";
            kSmith.StudentId = "123456";
            kSmith.IncreaseCoursesTaken();

            Student bJones = new Student(2,"Bob Jones","654321");
            bJones.IncreaseCoursesTaken();

            kSmith.OutputStudentDetails();
            bJones.OutputStudentDetails();
       }
    }
}
