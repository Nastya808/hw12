using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace hw12
{
    /*
    public class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"П'єса: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Рік: {Year}");
        }

        ~Play()
        {
            Console.WriteLine($"П'єса {Title} була видалена.");
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"П'єса {Title} була звільнена.");
                }
                disposed = true;
            }
        }
    }

    */

    public class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public StoreType Type { get; set; }

        public Store(string name, string address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Назва магазину: {Name}");
            Console.WriteLine($"Адреса магазину: {Address}");
            Console.WriteLine($"Тип магазину: {Type}");
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"Магазин {Name} був закритий.");
                }
                disposed = true;
            }
        }
    }

    public enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

}