using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDatabaseK25
{
    public static class CommandsManager
    {
        public static Dictionary<string, ICommand> Commands { get; set; }
        static CommandsManager()
        {
            Commands = new Dictionary<string, ICommand>();
            var availableCommands = typeof(Commands).GetNestedTypes();
            foreach (var command in availableCommands)
            {
                if (typeof(ICommand).IsAssignableFrom(command))
                    Commands[command.Name.ToLower()] = (ICommand)Activator.CreateInstance(command);
            }
        }

        public static void HandleCommands()
        {
            Console.WriteLine("Available commands:");
            foreach (var item in Commands)
            {
                Console.WriteLine(item.Key.ToString());
            }
            string typedCommand = null;
            while (true)
            {
                typedCommand = Console.ReadLine().ToLower();
                if (!Commands.ContainsKey(typedCommand))
                {
                    Console.WriteLine($"Typed command `{typedCommand}' isn't supported yet");
                }
                else
                {
                    Commands[typedCommand].Execute();
                }
            }
        }
        public static void HandleCommands(string typedCommand)
        {
                if (!Commands.ContainsKey(typedCommand))
                {
                    Console.WriteLine($"Typed command `{typedCommand}' isn't supported yet");
                }
                else
                {
                    Commands[typedCommand].Execute();
                }         
        }
    }
}
