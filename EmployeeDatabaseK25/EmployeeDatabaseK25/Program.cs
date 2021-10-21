using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialization.Deserialize2();
            CommandsManager.HandleCommands();
        }
    }
}
