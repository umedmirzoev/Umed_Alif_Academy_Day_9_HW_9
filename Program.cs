using Umed_Alif_Academy_Day_9_HW_9;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to CRM!");

        while (true)
        {
            Console.WriteLine("Enter a command: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "create client")
            {
                CreateClient();
            }
            else if (input == "create order")
            {
                CreateOrder();
            }
            else if (input == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }

    private static void CreateClient()
    {
        try
        {
            Console.WriteLine("Enter the First Name of the client:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Last Name of the client:");
            string lastName = Console.ReadLine().Trim();

            Console.WriteLine("Enter the Email of the client:");
            string email = Console.ReadLine().Trim();

            var clientInfo = new ClientInfo(firstName, lastName, email);

            // Save the client to CRM 
            Console.WriteLine("Client created successfully!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid client information: {ex.Message }");
        }
    }

    private static void CreateOrder()
    {
        try
        {
            Console.WriteLine("Enter the Order Number:");
            string orderNumber = Console.ReadLine().Trim();

            var orderInfo = new OrderInfo(orderNumber, DateTime.Now);

            // Save the order to CRM
            Console.WriteLine("Order created successfully!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid order information: {ex.Message}");
        }
    }
}
