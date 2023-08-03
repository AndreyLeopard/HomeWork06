using System;
using System.Data;
using System.Globalization;
using MyLib;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
            {
                maxValue++;
                Random random = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(minValue, maxValue);
                    }
                }
            }

            void PrintArray(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

             void Task41()
            {
                /* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
                сколько чисел больше 0 ввёл пользователь */

                int countOfNumbers = MyLibClass.Input("Сколько числе хотите ввести? ");
                int count = 0;
                for (int i = 1; i <= countOfNumbers; i++)
                {
                    int number = MyLibClass.Input($"Введите {i} число: ");
                    if (number > 0) count++;
                }
                Console.WriteLine($"Вы ввели {count} чисел(-ла) больше нуля.");

            }

            void Task43()
            {
                /* Задача 43: Напишите программу, которая найдёт точку пересечения
                двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
                значения b1, k1, b2 и k2 задаются пользователем. */
                double k1 = MyLibClass.Input("k1: ");
                double b1 = MyLibClass.Input("b1: ");
                int k2 = MyLibClass.Input("k2: ");
                int b2 = MyLibClass.Input("b2: ");

                if (k1 != k2)
                {
                    double x = (b2 - b1) / (k1 - k2);
                    x = Math.Round(x, 2);
                    double y1 = Math.Round(k1 * x + b1, 2);
                    double y2 = Math.Round(k2 * x + b2, 2);
                    Console.WriteLine($"A({x}, {y1})");
                    Console.WriteLine($"A({x}, {y2})");
                }
                else
                {
                    Console.WriteLine($"Прямые параллельны");
                }


            }

            Console.Clear();
            Task43();
        }
    }
}   