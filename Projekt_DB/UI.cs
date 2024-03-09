using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DB
{
    public class UI
    {
        public void Start()
        {
            Commands commands = new Commands();
            Console.WriteLine("Welcome to the database application!");
            do
            {
                Console.WriteLine("Here is a list of commands you can use: ");
                commands.ListCommands();
                Console.WriteLine("Please write command you want to use:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Selected command: " + commands.getCommand(0));

                        break;
                    case "2":
                        Console.WriteLine("Selected command: " + commands.getCommand(1));
                        break;
                    case "3":
                        Console.WriteLine("Selected command: " + commands.getCommand(2));
                        break;
                    case "4":
                        Console.WriteLine("Selected command: " + commands.getCommand(3));
                        break;
                    case "5":
                        Console.WriteLine("Selected command: " + commands.getCommand(4));
                        break;
                    case "6":
                        Console.WriteLine("Selected command: " + commands.getCommand(5));
                        break;
                    case "7":
                        Console.WriteLine("Selected command: " + commands.getCommand(6));
                        break;
                    case "8":
                        Console.WriteLine("Selected command: " + commands.getCommand(7));
                        break;
                    case "9":
                        Console.WriteLine("Selected command: " + commands.getCommand(8));
                        break;
                    case "10":
                        Console.WriteLine("Selected command: " + commands.getCommand(9));
                        break;
                    case "11":
                        Console.WriteLine("Selected command: " + commands.getCommand(10));
                        break;
                    case "12":
                        Console.WriteLine("Selected command: " + commands.getCommand(11));
                        break;
                    case "13":
                        Console.WriteLine("Selected command: " + commands.getCommand(12));
                        break;
                    case "14":
                        Console.WriteLine("Selected command: " + commands.getCommand(13));
                        break;
                    case "15":
                        Console.WriteLine("Selected command: " + commands.getCommand(14));
                        break;
                    case "16":
                        Console.WriteLine("Selected command: " + commands.getCommand(15));
                        break;
                    case "17":
                        Console.WriteLine("Selected command: " + commands.getCommand(16));
                        break;
                    case "18":
                        Console.WriteLine("Selected command: " + commands.getCommand(17));
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            } while (true);

        }
    }
}
