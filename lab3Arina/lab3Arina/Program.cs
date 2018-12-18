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
        public abstract void Display(double[] a);
        public abstract void Sort(ref double[] a);
        public abstract double[] Processing(double[] a);
    }

    class Bubble : Container
    {
        public override void Sort(ref double[] a)
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

        public override double[] Processing(double[] a)
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
        }

        public override double[] Processing(double[] a)
        {
            double[] result = new double[a.Length];
            int min;
            for (int i = 0; i < a.Length - 1; i++)
            {
                min = i;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                    
                }
            }
        }

        public override void Sort(ref double[] a)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Container c = new Bubble();
            double[] a = new double[] {1, 6, 9, 21, 0, -24};
            c.Sort(ref a);
            c.Display(a);
            c.Display(c.Processing(a));

            Console.Read();
        }
    }
}
