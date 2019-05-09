using System;
using System.ComponentModel.DataAnnotations;

namespace ComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //Console.ReadLine();

            var emp1Address = new Address
            {
                AddressLine1 = "Microsoft Corporation",
                AddressLine2 = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                Zip = "98052-6399"
            };

            var emp1 = new Employee {FirstName = "Bill", LastName = "Gates", EmployeeAddress = emp1Address};


            var emp2Address = new Address
            {
                AddressLine1 = "Gates Foundation",
                AddressLine2 = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                Zip = "98052-6399"
            };

            var emp2 = new Employee {FirstName = "Melinda", LastName = "Gates", EmployeeAddress = emp2Address};

            Compare.GetDifferences(emp1, emp2);

            Compare.SimpleReflectionCompare(emp1, emp2);

            Compare.RecrusiveReflectionCompare(emp1, emp2);

        }
    }
}
