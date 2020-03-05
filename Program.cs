using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string[] books = new string[0];
            Console.WriteLine("Добро пожаловать в обитель хикки-задрота \nТы можешь: \nДобавить книгу - клацни 1\nПосмотреть книги - клацни 2");
            while (true)
            {
                Console.WriteLine("Что делаем?");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.WriteLine("Что добавляем, семпай?");
                    string add = Console.ReadLine();
                    books = Add(books, add);
                    
                    Console.WriteLine("Добавлено, беги, смотри");
                }
                if (choose == "2")
                {
                    Console.WriteLine("Пожалуйста, выбирай :3\n");
                    Show(books);
                }
            }
        }
        static string[] Add(string[] array, string newValue)
        {
            
            int newLength = array.Length + 1;

            string[] result = new string[newLength];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            result[newLength - 1] = newValue;
            return result;
        }
       
        static void Show(string[] array)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Array.Sort(array);
            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
