using System;

namespace OOP4._2
{
    class Book
    {
        private int diapazon;
        public int Year
        {
            get
            {
                return diapazon;
            }
            set
            {
                if (value >= 1940 && value <= 2020)
                    Console.WriteLine("Год выпуска в диапозоне");
                else
                    Console.WriteLine("Год выпуска не в диапозоне от 1940 до 2020, повторите попытку");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год создания книги в диапозоне от 1940 до 2020");
            int godknigi = Convert.ToInt32(Console.ReadLine());
            Book Book = new Book();
            Book.Year = godknigi;
            Console.ReadLine();
        }
    }
}
