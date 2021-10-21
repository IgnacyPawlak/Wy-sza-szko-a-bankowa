using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeDatabaseK25
{
    public static class Serialization
    {
        static string filePath = "lista.dat";
        public static void Serialize2()
        {
            FileStream fs;
            BinaryFormatter bf = new BinaryFormatter();
            fs = File.Open(filePath, System.IO.FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, EmployeesManager.Employees);
        }
        public static void Deserialize2()
        {
            if (File.Exists(filePath))
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    EmployeesManager.Employees = (List<Employee>)bf.Deserialize(fs);
                }
            }
        }
    }
}
