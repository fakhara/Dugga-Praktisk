namespace Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inmatning av två tal
            double num1 = GetValidNumber("Ange det första talet:");
            double num2 = GetValidNumber("Ange det andra talet:");

            // Utför alla fyra räkneoperationerna
            Console.WriteLine($"\nAddition: {num1} + {num2} = {Add(num1, num2)}");
            Console.WriteLine($"Subtraktion: {num1} - {num2} = {Subtract(num1, num2)}");
            Console.WriteLine($"Multiplikation: {num1} * {num2} = {Multiply(num1, num2)}");
            Console.WriteLine($"Division: {num1} / {num2} = {Divide(num1, num2)}");
        }

        // Metod för addition
        static double Add(double a, double b)
        {
            return a + b;
        }

        // Metod för subtraktion
        static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Metod för multiplikation
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Metod för division
        static double Divide(double a, double b)
        {
            // Hantera delning med noll
            if (b == 0)
            {
                Console.WriteLine("Fel! Division med noll är inte tillåten.");
                return 0;
            }
            return a / b;
        }

        // Metod för att validera och hämta ett giltigt nummer
        static double GetValidNumber(string prompt)
        {
            double number = 0;
            bool validInput = false;

            // Loop för att säkerställa giltig inmatning
            while (!validInput)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                // Försök att konvertera inmatningen till ett flyttal (double)
                if (double.TryParse(input, out number))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning! Vänligen mata in ett giltigt nummer.");
                }
            }
            return number;
        }

    }
}