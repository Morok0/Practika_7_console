using System;
using System.Linq;

namespace Pr_7_zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();
            Console.WriteLine("Исходная строка: " + line);
            Console.WriteLine("Введите символ x: ");
            char x = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ y: ");
            char y = char.Parse(Console.ReadLine());

            int countX = line.Where(a => a == x).Count();//это просто счётчик, который считает символы
            int countY = line.Where(a => a == y).Count();
            string result = "Символ '{0}' встречается чаще в строке.";
            if (line.Contains((char) x)|| line.Contains((char)y))
            {
                if (countX > countY)//строчные и заглавные символы, это два разных симввола даже если это одна буква
                Console.WriteLine(result, x);
            else if (countY > countX)
                Console.WriteLine(result, y);
            else if (countY == countX )
                Console.WriteLine("Символы '{0}' и '{1}' встречаются одинаковое количество раз в строке.", x, y);

            }
            else Console.WriteLine("Таких символов нет");

            Console.ReadKey();
        }
    }
}
