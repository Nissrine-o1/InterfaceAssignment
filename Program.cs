// Program.cs
using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object
            Employee employee = new Employee() 
            { 
                FirstName = "John", 
                LastName = "Doe" 
            };

            // Polymorphism: we can use an interface type to reference the object
            IQuittable quittableEmployee = employee;

            // Call the Quit method through the interface
            quittableEmployee.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
