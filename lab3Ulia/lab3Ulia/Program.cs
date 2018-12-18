using System;
using System.Security.Cryptography;

namespace lab3Ulia
{
    public abstract class Body
    {
        protected double v, s;
        public virtual double Square()
        {
            return 0;
        }
        public virtual double Volume()
        {
            return 0;
        }
        public abstract void Display();
        public abstract void Input();
    }

    public class Parallepiped : Body
    {
        double a, b, c;

        public Parallepiped()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public override double Square()
        {
            s = a * b * 2 + b * c * 2 + a * c * 2;
            return s;
        }

        public override double Volume()
        {
            v = a * b * c;
            return v;
        }

        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Площадь параллелепипеда {0}. Объем параллелепипеда {1}", s, v);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public override void Input()
        {
            Console.WriteLine("Введите A, B, C");
            while (!Double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Введите число с плавающей точкой");
            while (!Double.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Введите число с плавающей точкой");
            while (!Double.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Введите число с плавающей точкой");
        }
    }

    public class Ball : Body
    {
        double R;

        public Ball()
        {
            R = 0;
        }
        public override double Square()
        {
            s = 4 * Math.PI * Math.Pow(R, 2); ;
            return s;
        }
        public override double Volume()
        {
            v = 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
            return v;
        }
        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Площадь шара {0:f3}. Объем шара {1:f3}", s, v);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public override void Input()
        {
            Console.WriteLine("Введите радиус шара");
            while (!Double.TryParse(Console.ReadLine(), out R))
                Console.WriteLine("Введите число с плавающей точкой");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Body paral = new Parallepiped();
            Body ball = new Ball();
            paral.Input();
            paral.Square();
            paral.Volume();
            paral.Display();
            ball.Input();
            ball.Square();
            ball.Volume();
            ball.Display();
            Console.ReadLine();
        }
    }
}


