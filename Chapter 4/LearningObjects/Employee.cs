using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningObjects
{
    public class Employee
    {
        //Declare variables for the class (auto-implemented properties)
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        //Declare constructors for the class
        //A) A parameterless constructor
        public Employee()
        {

        }

        //B) A greedy constructor
        public Employee(string name, int age, double salary, DateTime startedOn, string phone)
        {
            //TODO:  Write code for the body of the greedy constructor
            //Take all the values passed into the parameter variables,
            //  and store those values in our properties.
            //The purpose of a constructor is to put meaningful information 
            //  into properties and fields.

            Name = name;
            Age = age;
            Salary = salary;
            StartingDate = startedOn;
            PhoneNumber = phone;
        }

        //Method to assign an increase to the salary
        public void AssignBonus(double increasePercentage)
        {
            //Should validate the increasePercentage first but not right now...
            Salary += Salary * increasePercentage;
            //Exactly the same as Salary = Salary + (Salary * increasePercentage)
        }
    }
}
