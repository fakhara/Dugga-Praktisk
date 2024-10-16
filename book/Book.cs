using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class Book :IMediaItem
    {
         // Properties from IMediaItem
        public string Title { get; set; }
        public int Rating { get; set; } // Will be set only if the book has been read

        // Additional properties
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public bool HasRead { get; set; }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Titel: {Title}, Författare: {Author}, Sidor: {NumberOfPages}, Läst: {(HasRead ? "Ja" : "Nej")}, Betyg: {(HasRead ? Rating.ToString() + "/5" : "N/A")}");
        }

    }
}
