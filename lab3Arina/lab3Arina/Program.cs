using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
  //Создать абстрактный базовый класс Container с виртуальными методами sort() и 
  //поэлементной обработки контейнера foreach(). Разработать производные классы Bubble(пузырек) и Choice(выбор). 
  //В первом классе сортировка реализуется методом пузырька, а поэлементная обработка 
 //состоит в извлечении квадратного корня.Во втором классе сортировка реализуется методом выбора, 
 //а поэлементная обработка – вычисление логарифма.

namespace lab3Arina
{
    
    abstract class Container
    {
        public const int size = 10;
        public double[] a = new double[size];
        protected Random rnd = new Random();
        public abstract void Display(double[] a);
        public virtual void Input()
        {
            for (int i = 0; i < size; i++)
            {
                double value = rnd.NextDouble() * (1 - 100) + 100;
                a[i] = value;
            }
        }
        public abstract void Sort();
        public abstract double[] Processing();
    }

    class Bubble : Container
    {
        public override void Sort()
        {
            double temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        public override double[] Processing()
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = Math.Sqrt(Math.Abs(a[i]));
                
            }
            return result;
        }

        public override void Display(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0:0.00} ",a[i]);
            }
            Console.WriteLine();
        }
    }

    class Choice : Container
    {
        public override void Display(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0:0.00} ", a[i]);
            }
            Console.WriteLine();
        }

        public override double[] Processing()
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = Math.Log(a[i]);
            }
            return result;
        }

        public override void Sort()
        {
            int min;
            for (int i = 0; i < a.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                double temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Container b = new Bubble();
            Container c = new Choice();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Метод Bubble");
            Console.BackgroundColor = ConsoleColor.Black;
            b.Input();
            Console.WriteLine("Случайные числа");
            b.Display(b.a);
            Console.WriteLine("Сортируем...");
            b.Sort();
            b.Display(b.a);
            Console.WriteLine("Вычисляем квадратный корень каждого элемента");
            b.Display(b.Processing());

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Метод Choice");
            Console.BackgroundColor = ConsoleColor.Black;
            c.Input();
            Console.WriteLine("Случайные числа");
            c.Display(c.a);
            Console.WriteLine("Сортируем...");
            c.Sort();
            c.Display(c.a);
            Console.WriteLine("Вычисляем квадратный корень каждого элемента");
            c.Display(c.Processing());
            Console.Read();
        }
    }
}
