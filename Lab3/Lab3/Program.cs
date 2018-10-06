using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task
{
    class Program
    {
        public static double GetLength(double a, double b) // Длину интервала
        {
            if (a >= 0 && b >= 0) return b - a;
            if (a <= 0 && b >= 0) return Math.Abs(a) + Math.Abs(b);
            return Math.Abs(a) - Math.Abs(b);
        }

        public static int FindMaxLength(double[] mas) // Интервал с макс длиной
        {
            int indexMaxLengthA, indexMaxLengthB;
            indexMaxLengthA = 0;
            indexMaxLengthB = 1;

            double maxLength = GetLength(mas[indexMaxLengthA], mas[indexMaxLengthB]);

            for (int i = 2; i < mas.Length; i += 2)
            {
                double length = GetLength(mas[i], mas[i + 1]);

                if (maxLength < length)
                {
                    maxLength = length;
                    indexMaxLengthA = i;
                    indexMaxLengthB = i + 1;
                }
            }
            return indexMaxLengthA;
        }

        public static void InputMassiv(double[] mas)
        {
            for (int index = 0; index < mas.Length; index++)
            {
                mas[index] = double.Parse(Console.ReadLine());
            }
        }

        public static bool Task(double[] mas, int indexMaxLengthA, int indexMaxLengthB)
        {
            bool temp = true;


            int j = 0;

            while (temp && j < mas.Length)
            {
                if (mas[indexMaxLengthB] >= 0)
                {
                    if (!(mas[j] >= mas[indexMaxLengthA] && mas[j] <= mas[indexMaxLengthB] && (mas[j + 1] >= mas[indexMaxLengthA] && mas[j + 1] <= mas[indexMaxLengthB])))
                    {
                        temp = false;
                    }
                }
                
                j += 2;
            }
            return temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int masLength = int.Parse(Console.ReadLine());

            if (masLength % 2 == 0)
            {
                double[] mas = new double[masLength];

                InputMassiv(mas);

                int indexMaxLengthA, indexMaxLengthB;
                indexMaxLengthA = FindMaxLength(mas);
                indexMaxLengthB = indexMaxLengthA + 1;

                if (Task(mas, indexMaxLengthA, indexMaxLengthB)) Console.WriteLine($"Интревал ({mas[indexMaxLengthA]}, {mas[indexMaxLengthB]}) включает все интервалы");
                else Console.WriteLine("Нужный интервал не нашли");

            }
            else Console.WriteLine("Не все интервалы имеют концы");
            Console.ReadLine();
            
        }
    }
}