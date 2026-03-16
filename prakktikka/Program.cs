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

        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        static void FindMinMax(out int min, out int max, params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Ошибка: массив пуст.");
                min = max = 0;
                return;
            }

            min = numbers[0];
            max = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;

                if (number > max)
                    max = number;
            }
        }

        

        static void FillRandom(int[] array, int min, int max)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }
        }

        static int CountEven(int[] array, int index = 0)
        {
            if (index == array.Length)
            {
                return 0;
            }

            int count = 0;

            if (array[index] % 2 == 0)
            {
                count = 1;
            }

            return count + CountEven(array, index + 1);
        }

        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                    Console.Write(array[i]);
                else
                    Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"До обмена: a = {a}, b = {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");

            Console.WriteLine("Введите делимое: ");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите делитель: ");
            int divisor = int.Parse(Console.ReadLine());

            Divide(dividend, divisor, out int quotient, out int remainder);
            Console.WriteLine($"Частное: {quotient}, остаток: {remainder}");

            Console.WriteLine("Введите числа через пробел: ");
            string minmax = Console.ReadLine();

            string[] stringNumbers = minmax.Split(' ');
            int[] numbers = new int[stringNumbers.Length];

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numbers[i] = int.Parse(stringNumbers[i]);
            }

            FindMinMax(out int min, out int max, numbers);
            Console.WriteLine($"Минимум: {min}, максимум: {max}");

            

            int[] array = new int[10];

            FillRandom(array, 1, 100);

            Console.Write("Сгенерированный массив: ");
            PrintArray(array);

            int evenCount = CountEven(array);
            Console.WriteLine("Количество четных: " + evenCount);

            Console.WriteLine("Введите дополнительные числа через пробел: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(' ');
            int oldLength = array.Length;

            Array.Resize(ref array, array.Length + parts.Length);

            for (int i = 0; i < parts.Length; i++)
            {
                array[oldLength + i] = int.Parse(parts[i]);
            }

            Console.Write("Массив после добавления: ");
            PrintArray(array);

            evenCount = CountEven(array);
            Console.WriteLine("Количество четных: " + evenCount);
        }
    }
}
