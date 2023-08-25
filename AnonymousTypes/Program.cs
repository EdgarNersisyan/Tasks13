using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an anonymous type to store the details of a person including Name, Age, and IsStudent status.*/

            var person = new Person("John", 20, true);

            Console.WriteLine($"{person.Name} is {person.Age} and he {person.IsStudent} a student");
        }
    }
}
