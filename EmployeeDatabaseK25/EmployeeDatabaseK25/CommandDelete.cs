using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public partial class Commands
    {
        public class Delete : ICommand
        {
            public void Execute()
            {
                CommandsManager.HandleCommands("showlistofemployees");
                Console.WriteLine("type number of person you want to delete");
                bool inputIsAnInt = false;
                while (inputIsAnInt == false)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int inputNumber))
                    {
                        inputIsAnInt = true;
                        EmployeesManager.Employees.RemoveAt(inputNumber - 1);
                        Console.WriteLine("Employee deleted");
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
