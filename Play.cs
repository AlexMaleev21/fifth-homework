using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    internal class Play
    {
        public string PlayName { get; set; }
        public string AuthorInitials { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        private bool disposed = false;

        public Play(string playName, string authorInitials, string genre, string year)
        {
            PlayName = playName;
            AuthorInitials = authorInitials;
            Genre = genre;
            Year = year;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Play Name: {PlayName}");
            Console.WriteLine($"Author Initials: {AuthorInitials}");
            Console.WriteLine($"Playe genre: {Genre}");
            Console.WriteLine($"Play Year: {Year}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"{PlayName} has been disposed");
            }
            disposed = true;
        }

        ~Play()
        {
            Console.WriteLine();
            Console.WriteLine("All data has been cleared");
            Dispose(false);
        }


    }
}
