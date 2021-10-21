using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public partial class Commands
    {
        public class Edit : ICommand
        {
            public void Execute()
            {
                CommandsManager.HandleCommands("showlistofemployees");
                Console.WriteLine("Type number of person You want to edit: ");
                bool inputIsAnInt = false;
                while(inputIsAnInt == false)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int inputNumber))
                    {
                        inputIsAnInt = true;
                        Employee newEmployee = new Employee();
                        newEmployee.ConsoleRead();
                        EmployeesManager.Employees[inputNumber - 1] = newEmployee;
                        Console.WriteLine("Employee edited");
                    }
                    else
                    {
                        Console.WriteLine("wrong input format");
                    }
                }                
            }
        }
    }
}
