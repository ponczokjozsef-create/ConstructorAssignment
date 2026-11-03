using System;

namespace ConstructorAssignment
{
    // A simple Employee class used to demonstrate constructor chaining
    class Employee
    {
        // Properties that store the employee's data
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor #1 (the "full" constructor): takes both a first and a last name
        public Employee(string firstName, string lastName)
        {
            // Assign the parameter values to the properties
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Constructor with two parameters was called.");
        }

        // Constructor #2: takes only a first name.
        // ": this(firstName, "Unknown")" CHAINS this constructor to Constructor #1.
        // It first runs Constructor #1, passing "Unknown" as the last name,
        // and then runs the code inside this constructor's own body.
        public Employee(string firstName) : this(firstName, "Unknown")
        {
            Console.WriteLine("Constructor with one parameter was called.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. A const variable: its value is set once and can never be changed.
            //    Trying to assign a new value to it later would cause a compile error.
            const string companyName = "The Tech Academy";

            // 2. A variable declared with "var": C# figures out the type automatically
            //    from the value on the right side. Here it becomes a string.
            var greeting = "Welcome to " + companyName + "!";

            // Print the const and var values
            Console.WriteLine(greeting);

            // 3. Create an employee using the one-parameter constructor.
            //    Because of constructor chaining, the two-parameter constructor runs first.
            Console.WriteLine("\nCreating employee1 with only a first name:");
            Employee employee1 = new Employee("Joseph");
            Console.WriteLine("Employee 1: " + employee1.FirstName + " " + employee1.LastName);

            // Create another employee using the two-parameter constructor directly
            Console.WriteLine("\nCreating employee2 with a first and last name:");
            Employee employee2 = new Employee("Jane", "Doe");
            Console.WriteLine("Employee 2: " + employee2.FirstName + " " + employee2.LastName);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}