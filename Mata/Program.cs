namespace Mata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            bool validInput = false;

            // Loop to handle incorrect inputs
            while (!validInput)
            {
                Console.WriteLine("Enter a number between -200 and 200 (not over 200 or under -200):");

                try
                {
                    // Try to read in the user's input and convert to an integer
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput > 200 || userInput < -200)
                    {
                        Console.WriteLine("The number must be between -200 and 200. Try again.");
                    }
                    else
                    {
                        validInput = true; 
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                }
            }
            // Once a valid number is entered, perform the necessary printing based on the user's number
            if (userInput > 100)
            {
                Console.WriteLine($"\nYou have entered {userInput}. The numbers from {userInput} down to 100 is:");
                for (int i = userInput; i >= 100; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else if (userInput < 100)
            {
                Console.WriteLine($"\nYou have entered {userInput}. The numbers from {userInput} up to 100 is:");
                for (int i = userInput; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Du har matat in talet 100.");
            }
        }
    }
}