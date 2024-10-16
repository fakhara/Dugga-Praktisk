using System.Diagnostics.CodeAnalysis;

namespace Dugga_Praktisk
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* Person person = new Person("Fakhara ", "Imran", "199001012345", "Emilvägen 28, 35257 växjö");

            // Visa information om personen
            person.DisplayInfo();*/



            Employee employee = new Employee("Fakhara", "Imran", "199001012345", "Emilvägen 12, 35257 Växjö", 500000, "IT");

            // Visa information om den anställda
            employee.DisplayInfo();

            // Ge en löneökning på 10%
            employee.IncreaseSalary(10);

            // Visa information efter löneökningen
            Console.WriteLine("\nEfter löneökning:");
            employee.DisplayInfo();

        }
    }
}