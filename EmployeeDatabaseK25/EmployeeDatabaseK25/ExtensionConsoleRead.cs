using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public static partial class Extensions
    {
        public static void ConsoleRead(this IConsoleReadable readable)
        {
            var properties = readable.GetType()
                                     .GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"Type value of the property `{property.Name}'");
                if (typeof(IConsoleReadable).IsAssignableFrom(property.PropertyType))
                {
                    IConsoleReadable propValue = (IConsoleReadable)property.GetValue(readable);
                    propValue.ConsoleRead();
                }
                else if (property.PropertyType.IsEnum)
                {
                    string line = Console.ReadLine();
                    property.SetValue(readable, Enum.Parse(property.PropertyType, line));
                }
                else
                {
                    string line = Console.ReadLine();
                    property.SetValue(readable, Convert.ChangeType(line, property.PropertyType));
                }
                
            }
        }
    }
}
