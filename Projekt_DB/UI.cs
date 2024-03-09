namespace Projekt_DB
{
    public class UI
    {
        public void Start()
        {
            Commands commands = new Commands();
            CommandMethods commandMethods = new CommandMethods();
            commandMethods.FillCommandsInList();
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
                        commandMethods.ListCostumers();
                        break;
                    case "2":
                        commandMethods.ListOrders();
                        break;
                    case "3":
                        commandMethods.ListProducts();
                        break;
                    case "4":
                        commandMethods.ListOrdersByCustomer();
                        break;
                    case "5":
                        commandMethods.ListItemsInOrder();
                        break;
                    case "6":
                        commandMethods.AddCustomer();
                        break;
                    case "7":
                        commandMethods.AddOrder();
                        break;
                    case "8":
                        commandMethods.AddProduct();
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
                        commandMethods.Exit();
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            } while (true);

        }
    }
}
