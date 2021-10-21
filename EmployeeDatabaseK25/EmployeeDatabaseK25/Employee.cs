using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    [Serializable]
    public class Employee: IConsoleReadable
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Address Address { get; set; } = new Address();
    }
}
