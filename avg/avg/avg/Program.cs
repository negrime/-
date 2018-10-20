using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg
{
    class Base //базовые ф-ии (сравнение,min,max)
    {
        private const double e = 1E-5; //точность
                                       //сравнение 1-больше; 0-равны; -1-меньше; >=(<=)0-больше(меньше) или равно
        public static int Compare(double a, double b)
        {
            int result = 1;
            double r = a - b; //разность
            if (r <= e)
            {
                result = 0;
            }
            else
                if (r < 0)
            {
                result = -1;
            }
            return result;
        }
        //максимальное
        public static double Max(double a, double b)
        {
            if (Compare(a, b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        //инимальное
        public static double Min(double a, double b)
        {
            if (Compare(a, b) < 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
    class Point //точка в ДСК
    {
        public double x, y; //координаты
                            //конструктор 
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //проверка на равенство точек
        public static bool EqPoints(Point A, Point B)
        {
            return ((Base.Compare(A.x, B.x) == 0) && (Base.Compare(A.y, B.y) == 0));
        }
        //вычисление расстояния между двумя точками
        public static double Distance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }
    }
    //класс вектор
    class Vector
    {
        private bool Decart; //вид координат
        public double x, y, z; //координаты в ДСК
        private double r, p; //координаты в ПСК (расстояние, угол)
        public Vector(double x, double y, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Decart = true;
        }
        //из декартовой в полярную
        static public void DecartToPolar(Vector V)
        {
            V.r = Math.Sqrt(V.x * V.x + V.y + V.y);
            V.p = (Base.Compare(V.r, 0) == 0) ? 0 : (Math.Atan(V.y / V.x));
            V.Decart = false;
        }
        //из полярной в декартовую
        static public void PolarToDecart(Vector V)
        {
            V.x = V.r * Math.Cos(V.p);
            V.y = V.r * Math.Sin(V.p);
            V.Decart = true;
        }
        //вектор через точки
        public Vector(Point A, Point B)
        {
            this.x = B.x - A.x;
            this.y = B.y - A.y;
            Decart = true;
        }
        //сумма
        static public Vector Sum(Vector V1, Vector V2)
        {
            Vector V3 = new Vector(V1.x + V2.x, V1.y + V2.y);
            return V3;
        }
        //разность
        static public Vector Differ(Vector V1, Vector V2)
        {
            Vector V3 = new Vector(V1.x - V2.x, V1.y - V2.y);
            return V3;
        }
        //умножение на число
        static public Vector Multiply(Vector V1, double n)
        {
            Vector V3 = new Vector(V1.x * n, V1.y * n);
            return V3;
        }
        //скалярное произведение
        static public double Scalar(Vector V1, Vector V2)
        {
            return V1.x * V2.x + V1.y * V2.y;
        }
        //векторное произведение
        static public Vector VectorMultiply(Vector V1, Vector V2)
        {

            Vector result = new Vector(V1.y * V2.z - V1.z * V2.y, V1.z * V2.x - V1.x * V2.z, V1.x * V2.y - V1.y * V2.x);
            result.z = V1.x * V2.y - V1.y * V2.x;
            //    Vector result = new Vector(1 *0 - 0 * 2, 0 * 2 - 2 * 0, 2 * 2 - 1 * 2);
            //result.x = 5;

            Console.WriteLine(result.z);
            return result;

        }

        public Vector(double r, double p)
        {
            this.r = r;
            this.p = p;
            Decart = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* double x1, y1;
             //ввод координат А
             Console.Write("Введите координату x первой точки: ");
             string str = Console.ReadLine();
             try
             {
                 x1 = double.Parse(str);
             }
             catch (FormatException exc)
             {
                 Console.WriteLine(exc.Message);
                 x1 = 0;
             }
             catch (OverflowException exc)
             {
                 Console.WriteLine(exc.Message);
                 x1 = 0;
             }
             Console.Write("Введите координату y первой точки: ");
             str = Console.ReadLine();
             try
             {
                 y1 = double.Parse(str);
             }
             catch (FormatException exc)
             {
                 Console.WriteLine(exc.Message);
                 y1 = 0;
             }
             catch (OverflowException exc)
             {
                 Console.WriteLine(exc.Message);
                 y1 = 0;
             }
             //ввод координат В
             double x2, y2;
             Console.Write("Введите координату x второй точки: ");
             str = Console.ReadLine();
             try
             {
                 x2 = double.Parse(str);
             }
             catch (FormatException exc)
             {
                 Console.WriteLine(exc.Message);
                 x2 = 0;
             }
             catch (OverflowException exc)
             {
                 Console.WriteLine(exc.Message);
                 x2 = 0;
             }
             Console.Write("Введите координату y второй точки: ");
             str = Console.ReadLine();
             try
             {
                 y2 = double.Parse(str);
             }
             catch (FormatException exc)
             {
                 Console.WriteLine(exc.Message);
                 y2 = 0;
             }
             catch (OverflowException exc)
             {
                 Console.WriteLine(exc.Message);
                 y2 = 0;
             }
             Console.Write("Расстояние между точками: ");
             Point A = new Point(x1, y1);
             Point B = new Point(x2, y2);
             Console.WriteLine(Point.Distance(A, B));*/
            Vector V1 = new Vector(25, 1);
            Vector V2 = new Vector(2, 2);

            Vector.VectorMultiply(V1, V2);
         
        }
    }
}


