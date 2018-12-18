using System;
using System.Security.Cryptography;

namespace lab3Ulia
{
    public abstract class Figure
    {
        protected double p, s;
        public virtual double Square()
        {
            return 0;
        }
        public virtual double Perimeter()
        {
            return 0;
        }
        public abstract void Display();
        public abstract void Input();
    }

    public class Rectangle : Figure
    {
        double a, b;

        public Rectangle()
        {
            a = 0;
            b = 0;
        }
        public override double Square()
        {
            s = a * b;
            return s;
        }

        public override double Perimeter()
        {
            p =  2 * (a + b);
            return p;
        }

        public override void Display()
        {
            Console.WriteLine("Площадь прямоугольника {0}. Периметр прямоугольника {1}", s, p);
        }

        public override void Input()
        {
            Console.WriteLine("Введите A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = double.Parse(Console.ReadLine());
        }
    }

    public class Circle : Figure
    {
        double R;

        public Circle()
        {
            R = 0;
        }
        public override double Square()
        {
            s = Math.PI * Math.Pow(R, 2);
            return s;
        }
        public override double Perimeter()
        {
            p = 2 * Math.PI * R;
            return p;
        }
        public override void Display()
        {
            Console.WriteLine("Площадь  круга {0:f3}. Периметр круга {1:f3}", s, p);
        }
        public override void Input()
        {
            Console.WriteLine("Введите радиус круга");
            R = double.Parse(Console.ReadLine());
        }
    }

    public class Trapeze : Figure
    {
        double a, b, c , d, h;

        public Trapeze()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            h = 0;
        }
        public override double Square()
        {
            s = (1.0 / 2.0) * h * (a + b);
            return s;
        }
        public override double Perimeter()
        {
            p = a + b + c + d;
            return p;
        }
        public override void Display()
        {
            Console.WriteLine("Площадь  трапеции {0:f3}. Периметр трапеции {1:f3}", s, p);
        }
        public override void Input()
        {
            Console.WriteLine("Введите A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите C");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите D");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите H");
            h = double.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure rect = new Rectangle();
            Figure circ = new Circle();
            Figure trap = new Trapeze();
            rect.Input();
            rect.Perimeter();
            rect.Square();
            rect.Display();
            Console.WriteLine();

            circ.Input();
            circ.Perimeter();
            circ.Square();
            circ.Display();
            Console.WriteLine();

            trap.Input();
            trap.Perimeter();
            trap.Square();
            trap.Display();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


