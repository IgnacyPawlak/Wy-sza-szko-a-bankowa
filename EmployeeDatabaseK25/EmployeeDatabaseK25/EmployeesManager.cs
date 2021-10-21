using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    [Serializable]
    public static class EmployeesManager
    {
        public static List<Employee> Employees { get; set; } 
            = new List<Employee>();
    }
}
