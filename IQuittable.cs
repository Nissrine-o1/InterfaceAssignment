// IQuittable.cs
using System;

namespace InterfaceAssignment
{
    // This interface defines a contract for any class that wants to be "quittable"
    public interface IQuittable
    {
        // Any class implementing this interface must have a Quit method
        void Quit();
    }
}
