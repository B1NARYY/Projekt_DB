using Projekt_DB.DAOs;
using Projekt_DB.Tables;

namespace Projekt_DB
{
    public class CommandMethods
    {
        Commands commands = new Commands();

        public void FillCommandsInList()
        {
            commands.FillCommands();
        }
        //Method for listing all customers
        public void ListCostumers()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(0));
            foreach (var customer in CustomerDAO.GetCustomers())
            {
                Console.WriteLine(customer);
            }
        }
        //Method for listing all orders
        public void ListOrders()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(1));
            foreach (var order in OrderDAO.GetOrders())
            {
                Console.WriteLine(order);
            }
        }
        //Method for listing all products
        public void ListProducts()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(2));
            foreach (var product in ProductDAO.GetProducts())
            {
                Console.WriteLine(product);
            }
        }
        //Method for listing all orders by customer
        public void ListOrdersByCustomer()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(3));
            Console.WriteLine("Enter customer id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var order in OrderDAO.GetOrdersByCustomerId(id))
            {
                Console.WriteLine(order);
            }
        }
        //Method for listing all items in order
        public void ListItemsInOrder()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(4));
            Console.WriteLine("Enter order id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var item in OrderItemDAO.GetItemsInOrder(id))
            {
                Console.WriteLine(item);
            }
        }
        //Method for adding customer
        public void AddCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("Selected command: " + commands.getCommand(5));
            Console.WriteLine("Enter customer name: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter customer email: ");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Eneter customer phone number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter customer address: ");
            customer.Address = Console.ReadLine();
            CustomerDAO customerDAO = new CustomerDAO();

            customerDAO.AddCustomer(customer);
        }
        //Method for adding order
        public void AddOrder()
        {
            Order order = new Order();
            Console.WriteLine("Selected command: " + commands.getCommand(6));
            Console.WriteLine("Enter customer id: ");
            order.CustomerId = Convert.ToInt32(Console.ReadLine());
            order.OrderDate = DateTime.Now;
            order.OrderStatus = "New";
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.AddOrder(order);

        }

        //Method for adding product
        public void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Selected command: " + commands.getCommand(7));
            Console.WriteLine("Enter product name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            product.Price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter product availability (1=available, 0=bnot): ");
            product.Availability = Convert.ToBoolean(Console.ReadLine());
            ProductDAO productDAO = new ProductDAO();
            productDAO.AddProduct(product);
        }
        //Method for removing order item
        public void RemoveOrderItem()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(8));
            Console.WriteLine("Enter order item id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            OrderItemDAO orderItemDAO = new OrderItemDAO();
            orderItemDAO.RemoveOrderItem(id);
        }
        //Method for updating customer info
        public void UpdateCustomerInfo()
        {
            Customer customer = new Customer();
            Console.WriteLine("Selected command: " + commands.getCommand(9));
            Console.WriteLine("Enter customer id: ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter customer email: ");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Eneter customer phone number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter customer address: ");
            customer.Address = Console.ReadLine();
            CustomerDAO customerDAO = new CustomerDAO();
            customerDAO.UpdateCustomerInfo(customer);
        }

        //Method for updating shipping details
        public void UpdateShippingDetails()
        {
            ShippingDetails shippingDetails = new ShippingDetails();
            Console.WriteLine("Selected command: " + commands.getCommand(10));
            ShippingDetailsDAO shippingDetailsDAO = new ShippingDetailsDAO();
            Console.WriteLine("Enter shipping id: ");
            shippingDetails.ShippingId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter shipping address: ");
            shippingDetails.ShippingAddress = Console.ReadLine();
            Console.WriteLine("Enter shipping method: ");
            shippingDetails.ShippingMethod = Console.ReadLine();
            Console.WriteLine("Enter delivery status: ");
            shippingDetails.DeliveryStatus = Console.ReadLine();
            shippingDetailsDAO.UpdateShippingDetails(shippingDetails);
        }
        //Method for creating order and customer

        public void CreateOrderAndCustomer()
        {
            Customer customer = new Customer();
            Order order = new Order();

            Console.WriteLine("Selected command: " + commands.getCommand(11));
            Console.WriteLine("Enter customer name: ");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter customer email: ");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Eneter customer phone number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter customer address: ");
            customer.Address = Console.ReadLine();
            Console.WriteLine("Enter customer id: ");
            order.CustomerId = Convert.ToInt32(Console.ReadLine());
            order.OrderDate = DateTime.Now;
            order.OrderStatus = "New";
            CustomerOrderDAO customerOrderDAO = new CustomerOrderDAO();
            customerOrderDAO.CreateOrderAndCustomer(customer, order);


        }

        //Method for exiting the program
        public void Exit()
        {
            Console.WriteLine("Selected command: " + commands.getCommand(13));
            Environment.Exit(0);
        }
    }
}
