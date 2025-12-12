// Employee.cs
using System;

namespace InterfaceAssignment
{
    // Employee class implements IQuittable interface
    public class Employee : IQuittable
    {
        // Properties for employee's first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementation of Quit method from IQuittable interface
        public void Quit()
        {
            // Write a message to the console indicating the employee has quit
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}
