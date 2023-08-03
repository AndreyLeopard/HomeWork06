using System;

namespace MyLib
{
    public static class MyLibClass
    {
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void FillArray(int[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
        }

        public static void FillArray(double[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                //(0, 1)
                //(0, 1) * 10 => (0, 10)
                //(0, 10) - 5 => (-5, 5)
                //5, -5 = 10/5 - (-5)
                array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
                array[i] = Math.Round(array[i], 2);
            }
        }


        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

    }
}