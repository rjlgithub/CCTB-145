using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myApp = new Program();  //calls the Default Constructor

            Employee headProgrammer = myApp.CreateHeadProgrammer();
            Employee bossesNephew = myApp.CreateStudentProgrammer(25000);
            Employee saitStudent = myApp.CreateStudentProgrammer(21000);

            myApp.CompareSalary(saitStudent, bossesNephew);

            myApp.ApplyRaise(headProgrammer);
            Console.WriteLine(headProgrammer.ToString());
        }

        private void ApplyRaise(Employee someone)
        {
            //Ask user for raise amount, between 2 and 10 inclusive
            Console.Write("Enter raise amount (2-10): ");
            double raise = double.Parse(Console.ReadLine());
            while (raise < 2 || raise > 10)
            {
                Console.WriteLine("Not a valid value!");
                Console.Write("Enter raise amount (2-10): ");
                raise = double.Parse(Console.ReadLine());
            }

            raise = raise / 100;
            //change someone's salary
            someone.AssignBonus(raise);
        }

        private void CompareSalary(Employee personA, Employee personB)
        {
            double salaryDifference = personA.Salary - personB.Salary;
            //get the absolute value
            salaryDifference = Math.Abs(salaryDifference);

            string paidTheMost;
            string paidTheLeast;
            if (personA.Salary > personB.Salary)
            {
                paidTheMost = personA.Name;
                paidTheLeast = personB.Name;
            }
            else
            {
                paidTheMost = personB.Name;
                paidTheLeast = personA.Name;
            }

            Console.WriteLine(paidTheMost + " is paid $" + salaryDifference + " more than " + paidTheLeast);

        }

        private Employee CreateStudentProgrammer(double startingWage)
        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();
            Employee cheapWorker;
            //Create the employee object by calling the greedy constructor
            cheapWorker = new Employee(name, 20, startingWage, DateTime.Today, "780.555.2003");

            return cheapWorker;
        }

        private Employee CreateHeadProgrammer()
        {
            //Instantiate (create) an object using an Initializer List
            Employee allan = new Employee()
            { 
                Name = "Allan",
                Age = 27,
                Salary = 75000,
                StartingDate = new DateTime(2010, 10, 28),
                PhoneNumber = "780.555.1212"
            };
            //return the data
            return allan;
        }
    }
}
