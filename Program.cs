using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //int[] sides = new int[5];
            //for (int i = 0; i < sides.Length; i++)
            //{
            //    Console.Write($"Введите длину стороны {i + 1}: ");
            //    sides[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sum1 = sides.Sum();
            //Console.WriteLine($"Периметр пятиугольника (метод массива): {sum1}");

            //int sum2 = 0;
            //for (int i = 0; i < sides.Length; i++)
            //{
            //    sum2 += sides[i];
            //}
            //Console.WriteLine($"Периметр пятиугольника (вручную): {sum2}");


            //Задание 2
            //int[] profit = new int[12];
            //int Max = 0;
            //int Min = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.Write($"Введите прибыль за месяц {i + 1}: ");
            //    profit[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < 12; i++)
            //{
            //    if (profit[i] > profit[Max])
            //    {
            //        Max = i;
            //    }

            //    if (profit[i] < profit[Min])
            //    {
            //        Min = i;
            //    }
            //}
            //Console.WriteLine($"Максимальная прибыль в месяце {Max + 1}");
            //Console.WriteLine($"Минимальная прибыль в месяце {Min + 1}");


            //Задание 3
            //Random rand = new Random();
            //int[] arr = new int[10];
            //int SumElem = 0;
            //int SumIndex = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(-9, 9);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        SumElem += arr[i];
            //    }
            //}
            //for (int i = 0; i < arr.Length; i += 2)
            //{
            //    SumIndex += arr[i];
            //}

            //Console.WriteLine($"Сумма нечетных элементов: {SumElem}");
            //Console.WriteLine($"Сумма элементов с нечетными индексами: {SumIndex}");

        }
    }
}