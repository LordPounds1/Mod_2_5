using System;

namespace Mod_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int n = int.Parse(Console.ReadLine());
            char[] rev = n.ToString().ToCharArray();
            Array.Reverse(rev);
            int res = int.Parse(new string(rev));
            Console.WriteLine("Число, полученное при инверсии: " + res);
        }
    }
}
