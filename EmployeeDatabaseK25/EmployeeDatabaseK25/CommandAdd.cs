using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public partial class Commands
    {
        public class Add : ICommand
        {
            public void Execute()
            {
                Employee employee = new Employee();
                employee.ConsoleRead();
                EmployeesManager.Employees.Add(employee);
                Console.WriteLine("Employee added successfully");
            }
        }
    }
}
