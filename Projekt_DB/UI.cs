namespace Projekt_DB
{
    public class UI
    {
        //Method that starts the application
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
                        commandMethods.RemoveOrderItem();
                        break;
                    case "10":
                        commandMethods.UpdateCustomerInfo();
                        break;
                    case "11":
                        commandMethods.UpdateShippingDetails();
                        break;
                    case "12":
                        commandMethods.CreateOrderAndCustomer();
                        break;
                    case "13":
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
