using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Определить есть ли интервал, который является частью всех остальных
namespace Task
{
    class Program
    {
        public static int GetLength(int a, int b) // Длину интервала
        {
            if (a >= 0 && b >= 0) return b - a;
            if (a <= 0 && b >= 0) return Math.Abs(a) + Math.Abs(b);
            return Math.Abs(a) - Math.Abs(b);
        }

        public static int FindMinLength(int[] mas) // Интервал с макс длиной
        {
            int indexMinLengthA, indexMinLengthB;
            indexMinLengthA = 0;
            indexMinLengthB = 1;

            double minLength = GetLength(mas[indexMinLengthA], mas[indexMinLengthB]);

            for (int i = 2; i < mas.Length; i += 2)
            {
                int length = GetLength(mas[i], mas[i + 1]);

                if (minLength > length)
                {
                    minLength = length;
                    indexMinLengthA = i;
                    indexMinLengthB = i + 1;
                }
            }
            return indexMinLengthA;
        }

        public static void InputMassiv(int[] mas)
        {
            for (int index = 0; index < mas.Length; index++)
            {
                mas[index] = int.Parse(Console.ReadLine());
                if ((index + 1) % 2 == 0 && index != 0)
                {
                    if (mas[index] < mas[index -1])
                    {
                       int z;
                       z = mas[index];
                       mas[index] = mas[index - 1];
                       mas[index - 1] = z;                       
                    }
                }
            }
        }

        public static bool Task(int[] mas, int indexMaxLengthA, int indexMaxLengthB)
        {
            bool temp = true;
             

            int j = 0;

            while (temp && j < mas.Length)
            {
                if (mas[indexMaxLengthB] >= 0)
                {
                    // if (!(mas[j] >= mas[indexMaxLengthA] && mas[j] <= mas[indexMaxLengthB] && (mas[j + 1] >= mas[indexMaxLengthA] && mas[j + 1] <= mas[indexMaxLengthB])))
                    //  {///
                    //  temp = false;
                    //}

                    if (mas[indexMaxLengthA] >= mas[j] && mas[indexMaxLengthA] <= mas[j + 1]) 
                    {
                        
                    } 
                    else
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
                int[] mas = new int[masLength];
                InputMassiv(mas);
                int indexMaxLengthA, indexMaxLengthB;
                indexMaxLengthA = FindMinLength(mas);
                indexMaxLengthB = indexMaxLengthA + 1;

                if (Task(mas, indexMaxLengthA, indexMaxLengthB)) Console.WriteLine($"Интревал ({mas[indexMaxLengthA]}, {mas[indexMaxLengthB]}) включен во все интервалы");
                else Console.WriteLine("Нужный интервал не нашли");
            }
            else Console.WriteLine("Не все интервалы имеют концы");
            Console.ReadLine();            
        }
    }
}