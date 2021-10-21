using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public partial class Commands
    {
        public class Search : ICommand
        {
            public void Execute()
            {
                string input = null;
                input = Console.ReadLine().ToLower();
                Regex regex = new Regex(input, RegexOptions.IgnoreCase);
                var attributes = typeof(Employee).GetProperties();
                var addressProperties = typeof(Address).GetProperties();
                List<Employee> resultList = new List<Employee>();
                foreach (Employee item in EmployeesManager.Employees)
                {
                    foreach (var attribute in attributes)
                    {
                        if(attribute.PropertyType ==  typeof(String))
                        {
                            string b = attribute.GetValue(item).ToString().ToLower();
                            if(regex.IsMatch(b))
                            {
                                if(!resultList.Contains(item))
                                {
                                    resultList.Add(item);
                                }
                            }
                            else
                            {
                                foreach (var addressAttribute in addressProperties)
                                {
                                    string a = addressAttribute.GetValue(item.Address).ToString();
                                    if(regex.IsMatch(a))
                                    {
                                        if (!resultList.Contains(item))
                                        {
                                            resultList.Add(item);
                                        }
                                    }
                                }                                
                            }
                        }
                        else if (attribute.PropertyType == typeof(int))
                        {
                            if(int.TryParse(input, out int numberInput))
                            {
                                int propertyNumber = (int)attribute.GetValue(item);
                                if(numberInput == propertyNumber)
                                {
                                    if (!resultList.Contains(item))
                                    {
                                        resultList.Add(item);
                                    }
                                }                                
                            }

                        }
                    }                    
                }
                foreach (var item in EmployeesManager.Employees)
                {
                    if (resultList.Contains(item))
                    {
                        Console.Write(item.FirstName + " " +
                        item.Surname + " " + item.Age + " " +
                        item.Sex + " " + item.Address.City + " " +
                        item.Address.Street + " " + item.Address.PostalCode + " " +
                        item.Address.HouseNumber + " " + item.Address.FlatNumber);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
