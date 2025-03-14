/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService
{
    public static void Run()
    {
        // Example code to see what's in the customer service queue:

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");
        Console.WriteLine("The user shall specify the maximum size of the Customer Service Queue when it is created. If the size is invalid (less than or equal to 0) then the size shall default to 10.");
        Console.WriteLine("Specify the maximum size of the Customer Service Queue:");
        var max_size = int.Parse(Console.ReadLine());
        var cs = new CustomerService(max_size);

        Console.WriteLine("=================");

        Console.WriteLine("The AddNewCustomer method shall enqueue a new customer into the queue. The ServeCustomer function shall dequeue the next customer from the queue and display the details.");
        cs.AddNewCustomer();
        cs.ServeCustomer();
        Console.WriteLine("=================");

        Console.WriteLine("If the queue is full when trying to add a customer, then an error message will be displayed.");
        var cs_test_2 = new CustomerService(1);
        cs_test_2.AddNewCustomer();
        cs_test_2.AddNewCustomer();
        Console.WriteLine("=================");

        Console.WriteLine("If the queue is empty when trying to serve a customer, then an error message will be displayed.");
        var cs_test_3 = new CustomerService(1);
        cs_test_3.ServeCustomer();
        Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize)
    {
        if (maxSize <= 0)
        {
            Console.WriteLine("Invalid size. Defaulting to 10.");
            _maxSize = 10;
        }
        else
        {
            _maxSize = maxSize;
        }
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString()
        {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize)
        {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer()
    {

        if (_queue.Count == 0)
        {
            Console.WriteLine("No Customers in Queue.");
            return;
        }
        var customer = _queue[0];
        Console.WriteLine(customer);
        _queue.RemoveAt(0);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString()
    {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}