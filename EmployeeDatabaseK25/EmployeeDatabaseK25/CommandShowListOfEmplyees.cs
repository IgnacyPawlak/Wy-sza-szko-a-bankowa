using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public partial class Commands
    {
        public class ShowListOfEmployees : ICommand
        {
            public void Execute()
            {
                for (int i = 0; i < EmployeesManager.Employees.Count; i++)
                {
                    Console.Write((i+1).ToString() + ". " + EmployeesManager.Employees[i].FirstName+" " +
                        EmployeesManager.Employees[i].Surname + " " + EmployeesManager.Employees[i].Age + " " +
                        EmployeesManager.Employees[i].Sex + " " + EmployeesManager.Employees[i].Address.City + " " +
                        EmployeesManager.Employees[i].Address.Street + " " + EmployeesManager.Employees[i].Address.PostalCode + " " +
                        EmployeesManager.Employees[i].Address.HouseNumber + " " + EmployeesManager.Employees[i].Address.FlatNumber);
                    Console.WriteLine();
                }
            }
        }
    }
}
