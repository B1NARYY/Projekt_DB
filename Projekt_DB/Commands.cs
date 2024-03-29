﻿namespace Projekt_DB
{
    public class Commands
    {
        List<string> commands = new List<string>();
        private bool filled = false;

        // Method to list all commands
        public void ListCommands()
        {
            if (!filled)
            {
                FillCommands();
            }
            Console.WriteLine("\nCommands:");
            for (int i = 0; i < commands.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + commands[i]);
            }
        }
        // Method to fill the list with commands
        public void FillCommands()
        {
            AddCommand("1) List all customers");
            AddCommand("2) List all orders");
            AddCommand("3) List all products");
            AddCommand("4) List all orders of customer");
            AddCommand("5) List all items in order");
            AddCommand("6) Add a new customer");
            AddCommand("7) Add a new order");
            AddCommand("8) Add a new product");
            AddCommand("9) Remove an item from an order");
            AddCommand("10) Update a customer's details");
            AddCommand("11) Update shipping details");
            AddCommand("12) Create new order to new customer");
            AddCommand("13) Exit");

            filled = true;

        }
        // Method to add a command to the list
        public void AddCommand(string command)
        {
            commands.Add(command);
        }
        // Method to get a command from the list
        public string getCommand(int index)
        {
            return commands[index];
        }


    }
}
