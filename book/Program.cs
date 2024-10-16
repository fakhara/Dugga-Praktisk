using System;

namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Book book = new Book();
            // Get title
            book.Title = GetNonEmptyString("Ange bokens titel:");

            // Get author
            book.Author = GetNonEmptyString("Ange författarens namn:");

            // Get number of pages
            book.NumberOfPages = GetValidNumber("Ange antal sidor i boken:");

            // Ask if the user has read the book
            book.HasRead = GetYesOrNo("Har du läst boken? (Ja/Nej):");

            // If the user has read the book, get the rating
            if (book.HasRead)
            {
                book.Rating = GetValidRating("Ange ett betyg för boken (1-5):");
            }

            // Display the book information
            book.DisplayInfo();    */


            List<Book> books = new List<Book>();
            bool addingBooks = true;

            // Loop to add multiple books
            while (addingBooks)
            {
                Book book = new Book();

                // Get book details
                book.Title = GetNonEmptyString("Ange bokens titel:");
                book.Author = GetNonEmptyString("Ange författarens namn:");
                book.NumberOfPages = GetValidNumber("Ange antal sidor i boken:");
                book.HasRead = GetYesOrNo("Har du läst boken? (Ja/Nej):");

                if (book.HasRead)
                {
                    book.Rating = GetValidRating("Ange ett betyg för boken (1-5):");
                }

                books.Add(book);

                // Ask if user wants to add another book
                addingBooks = GetYesOrNo("Vill du lägga till en annan bok? (Ja/Nej):");
            }

            // Display all books
            Console.WriteLine("\nAlla böcker:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }

            // Ask if user wants to see the list of read books sorted by rating
            if (GetYesOrNo("\nVill du visa alla böcker du har läst, sorterade efter betyg? (Ja/Nej):"))
            {
                List<Book> readBooks = books.Where(b => b.HasRead).OrderByDescending(b => b.Rating).ToList();

                if (readBooks.Count > 0)
                {
                    Console.WriteLine("\nBöcker du har läst, sorterade efter betyg (högst till lägst):");
                    foreach (var book in readBooks)
                    {
                        Console.WriteLine($"{book.Title} - {book.Rating}/5");
                    }
                }
                else
                {
                    Console.WriteLine("Du har inte läst några böcker än.");
                }

            }
        }

        // Method to get a valid non-empty string from the user
        static string GetNonEmptyString(string prompt)
        {
            string input;
            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen mata in en icke-tom sträng.");
                }
            } while (string.IsNullOrEmpty(input));

            return input;
        }
        // Method to get a valid number (positive integer) from the user
        static int GetValidNumber(string prompt)
        {
            int number = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen mata in ett giltigt positivt heltal.");
                }
            }
            return number;
        }
        static bool GetYesOrNo(string prompt)
        {
            string input;
            while (true)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine().Trim().ToLower();
                if (input == "ja")
                {
                    return true;
                }
                else if (input == "nej")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen svara 'Ja' eller 'Nej'.");
                }
            }
        }
        static int GetValidRating(string prompt)
        {
            int rating = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out rating) && rating >= 1 && rating <= 5)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen ange ett betyg mellan 1 och 5.");
                }
            }
            return rating;
        }

    }
}