using System;
using System.Text;

namespace Ex38
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (var item in a)
            {
                sb.Append(item);
                sb.Append((char)rnd.Next((int)'а', (int)'я' + 1));
                sb.Append((char)rnd.Next((int)'а', (int)'я' + 1));
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey(true);
        }
    }
}
