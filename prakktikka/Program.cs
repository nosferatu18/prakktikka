using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakktikka
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a; 
            a = b;
            b = c;
        }

        static void Divide(int dividend, int divisor, out int quotient, out int remainder)//делимое делитель частное остаток
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            
        }

        static void FindMinMax(out int min, out int max, params int[] numbers)
        {
            numbers = new int[numbers.Length];
            if (numbers.Length > 0)
            {
                Console.WriteLine("Ошибка массив пуст.");
            }
            min = int.MinValue;
            max = int.MaxValue;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"До обмена: a = {a}, b = {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b} ");

            Console.WriteLine("Введите делимое: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель: ");
            int divisor = int.Parse(Console.ReadLine());

            Divide(dividend, divisor, out int quotient, out int remainder);
            Console.WriteLine($"Частное: {quotient}, остаток: {remainder}");

            Console.WriteLine("Введите числа через пробел: ");
            string minmax = Console.ReadLine();
            string[] stringNumbers = minmax.Split(' ');
            int[] numbers = new 
            int[stringNumbers.Length];

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = int.Parse(stringNumbers[i]);
            }
            FindMinMax(out int min, out int max);
            Console.WriteLine($"Минимум: {min}, максимум: {max}");
        }
    }
}
    