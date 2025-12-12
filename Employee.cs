// Define a class called Employee
// This class will inherit the IQuittable interface
public class Employee : IQuittable
{
    // Properties of the Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }

    // Implement the Quit method from IQuittable interface
    // This method is called when the employee quits
    public void Quit()
    {
        // For this example, just print a message to the console
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
    }
}
