/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Size of queue is set to -1
        // Expected Result: Size will be set to 10
        Console.WriteLine("Test 1");
        var CS = new CustomerService(-1);
        Console.WriteLine($"Size: {CS._maxSize}");

        // Defect(s) Found: None

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Customer is added to a queue of size 1
        // Expected Result: Customer is added with no errors thrown
        Console.WriteLine("Test 2");
        CS = new CustomerService(1);
        CS.AddNewCustomer();

        // Defect(s) Found: None

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: A second Customer is added to a queue of size 1
        // Expected Result: An error message will be displayed
        Console.WriteLine("Test 3");
        CS = new CustomerService(1);
        CS.AddNewCustomer();
        CS.AddNewCustomer();

        // Defect(s) Found: Off by 1 error allows for one more than max size Customers to be added

        Console.WriteLine("=================");

        // Test 4
        // Scenario: A Customer has been served and needs to be removed from queue
        // Expected Result: The first Customer in the queue will be removed from the queue with details printed out
        Console.WriteLine("Test 4");
        CS = new CustomerService(2);
        CS.AddNewCustomer();
        CS.AddNewCustomer();
        CS.ServeCustomer();

        // Defect(s) Found: The Customer data saved to be printed out was initialized after the customer was removed

        Console.WriteLine("=================");

        // Test 5
        // Scenario: A Customer is Removed while the queue is empty
        // Expected Result: An error message is displayed to show that the queue has no Customer to be removed
        Console.WriteLine("Test 5");
        CS = new CustomerService(1);
        CS.ServeCustomer();


        // Defect(s) Found: There is not a check to detect the queue being empty when removing a Customer

        Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
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
    private void ServeCustomer() {
        if (_queue.Count == 0)
        {
            Console.WriteLine("There are no Customers to serve.");
            return;
        }
        var customer = _queue[0];
        _queue.RemoveAt(0);
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}