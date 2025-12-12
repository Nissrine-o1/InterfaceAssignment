using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and assign properties
        Employee employee = new Employee()
        {
            FirstName = "John",
            LastName = "Doe",
            Id = 101
        };

        // Polymorphism: Declare an object of type IQuittable
        // Since Employee implements IQuittable, it can be assigned to this variable
        IQuittable quittableEmployee = employee;

        // Call the Quit method on the interface object
        // The runtime knows to execute the Employee's Quit method
        quittableEmployee.Quit();

        // Pause the console so we can see the output
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
