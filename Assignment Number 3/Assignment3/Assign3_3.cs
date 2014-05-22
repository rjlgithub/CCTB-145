using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assign3_3
    {
        public static void assignRun()
        {
            Random vR = new Random();
            Array officeDepartments = Enum.GetValues(typeof(OfficeDepartments));
            foreach (OfficeDepartments officeDepartment in officeDepartments)
            {
                int officeEmployees = vR.Next(1, 10);
                string departmentName = GetDepartmentName(officeDepartment);
                Console.WriteLine("Department: {0} has {1} Employees", departmentName, officeEmployees);
            }  //end foreach (OfficeDepartments officeDepartment in officeDepartments)
        }  //end private void assign33()

        enum OfficeDepartments
        {
            Accounting, HumanResources, InformationTechnology, Shipping, MailRoom, Management
        }

        static string GetDepartmentName(OfficeDepartments officeDepartment)
        {
            string departmentName = "";
            switch (officeDepartment)
            {
                case OfficeDepartments.Accounting:
                    departmentName = "Accounting";
                    break;
                case OfficeDepartments.HumanResources:
                    departmentName = "HumanResources";
                    break;
                case OfficeDepartments.InformationTechnology:
                    departmentName = "InformationTechnology";
                    break;
                case OfficeDepartments.Shipping:
                    departmentName = "Shipping";
                    break;
                case OfficeDepartments.MailRoom:
                    departmentName = "MailRoom";
                    break;
                case OfficeDepartments.Management:
                    departmentName = "Management";
                    break;
            }  //end switch (officeDepartment)
            return departmentName;
        }  //end static string GetDepartmentName(OfficeDepartments officeDepartment)
    }  //end class Program
}
