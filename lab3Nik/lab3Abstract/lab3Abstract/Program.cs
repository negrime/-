using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3Abstract
{
    class Program
    {
        public abstract class Function
        {
            protected abstract IEnumerable<double> Calc(double x, int a, int b);
            public abstract void Display(double x, int a, int b); 
        }

        public class Ellipse : Function
        {
            protected override IEnumerable<double> Calc(double x, int a, int b)
            {
                IEnumerable<double> result;
                if (a == 0 || b == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double y = b * Math.Sqrt(1 - Math.Pow(x, 2) / Math.Pow(a, 2));
                if (y == 0)
                {
                    result = new double[] { 0 };
                }
                else
                {
                    result = new double[] { y, -y };
                }
                return result;
                //return y == 0 ? new double[] { 0 } : new double[] { y, -y };
            }
            public override void Display(double x, int a, int b)
            {
                foreach (var item in this.Calc(2, 3, 6))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public class Hyper : Function
        {
            protected override IEnumerable<double> Calc(double x, int a, int b)
            {
                IEnumerable<double> result;
                if (a == 0 || b == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double y = Math.Sqrt(Math.Pow(b, 2) * (1 - (Math.Pow(x, 2) / Math.Pow(a, 2))));
                if (y == 0)
                {
                    result = new double[] { 0 };
                }
                else
                {
                    result = new double[] { y, -y };
                }
                return result;
                //return y == 0 ? new double[] { 0 } : new double[] { y, -y };
            }

            public override void Display(double x, int a, int b)
            {
                foreach (var item in Calc(2, 4, 3))
                {
                    Console.WriteLine(item);
                }

            }
        }

        public static void Read(out double x, out int a, out int b)
        {
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            b = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            double x;
            int a;
            int b;
            Ellipse e = new Ellipse();
            Hyper h = new Hyper();
            Read(out x, out a, out b);
            e.Display(x, a, b);
            h.Display(x, a, b);
            
            Console.Read();
        }
    }
}


