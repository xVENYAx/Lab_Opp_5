using System;

namespace Ex28
{
    class Program
    {



        static void Main(string[] args)
        {
            var str = "Дана строка. Удалите k символ в ней. ";
            var k = 21;
            var str2 = str.Substring(0, k) + str.Substring(k + 1);
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
    
}
