using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public partial class Commands
    {
        public class Quit : ICommand
        {
            public void Execute()
            {
                Serialization.Serialize2();
                Environment.Exit(0);
            }
        }
    }
}
