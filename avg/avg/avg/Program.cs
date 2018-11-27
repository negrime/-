using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*БАЗОВЫЕ ПРОЦЕДУРЫ 
1) Сравнение вещественных чисел (строго больше, строго меньше, равно, больше или равно, меньше или равно) 

ТОЧКА 
1) задать тип данных - точка на плоскости (в декартовой системе координат) 
2) проверка двух точек на совпадение 
3) вычисление расстояния между двумя точками на плоскости 

ВЕКТОР 
1) задать тип данных - вектор на плоскости (в декартовой системе координат, в полярной системе координат) 
2) операция перевода из декартовой системы координат в полярную и обратно 
3) построить вектор по координатам двух точек 
4) сумма двух векторов 
5) разность двух векторов 
6) умножение вектора на число 
7) скалярное произведение 
8) векторное произведение */

namespace ConsoleApp3
{
    public class Compare //Сравнение вещественных чисел (строго больше, строго меньше, равно, больше или равно, меньше или равно) 
    {
        public const double eps = 1e-3;
        public double x, y;

        public static bool RealEq(double x, double y) //строго равно
        {
            return ((Math.Abs(x - y) < eps) && (x * y >= 0));
        }
        public static bool RealMore(double x, double y) //строго больше
        {
            return (x - y > eps);
        }
        public static bool RealLess(double x, double y) //строго меньше 
        {
            return (x - y < -eps);
        }
        public static bool RealMoreEq(double x, double y) // x больше или равно y
        {
            return (x - y >= 0); // && (x - y < eps));
        }
        public static bool RealLessEq(double x, double y) //x меньше или равно y
        {
            return ((x - y <= 0) && (x - y < -eps));
        }
        public static double RealMin(double x, double y)
        {
            if (x - y > 0) return y;
            else return x;
        }

        public static double RealMax(double x, double y)
        {
            if (y - x > 0) return y;
            else return x;
        }
        public void Result(double x, double y)
        {
            if (RealEq(x, y)) Console.WriteLine("{0:F2} {1:F2} {2:F2}", x, " = ", y);
            else if (RealMore(x, y)) Console.WriteLine("{0:F2} {1:F2} {2:F2}", x, " > ", y);
            else if (RealLess(x, y)) Console.WriteLine("{0:F2} {1:F2} {2:F2}", x, " < ", y);
            else if (RealMoreEq(x, y)) Console.WriteLine("{0:F2} {1:F2} {2:F2}", x, " >= ", y);
            else if (RealLessEq(x, y)) Console.WriteLine("{0:F2} {1:F2} {2:F2}", x, " <= ", y);
        }

    }
    /*  ТОЧКА 
               1) задать тип данных - точка на плоскости(в декартовой системе координат)
               2) проверка двух точек на совпадение 
               3) вычисление расстояния между двумя точками на плоскости 
    */
    public class Point

    {
        const double eps = 1e-3;
        public double x, y;
        public Point(double a, double b)
        {
            x = a;
            y = b;
        }

        public Point()
        {
            InputCoord("Введите координаты точки");
        }
        public void InputCoord(string s)
        {
            Console.WriteLine(s);
            this.x = Convert.ToDouble(Console.ReadLine());
            this.y = Convert.ToDouble(Console.ReadLine());
        }


        public bool IsSeem(Point p1, Point p2) //проверка точек на совпадение
        {
            return Compare.RealEq(p1.x, p2.x) && Compare.RealEq(p1.y, p2.y);
        }

        public double Dist(Point p1)
        {
            if (IsSeem(this, p1))
            {
                return 0;
            }
            else
            {
                return Math.Sqrt((this.x - p1.x) * (this.x - p1.x) + (this.y - p1.y) * (this.y - p1.y));
            }
        }
        public bool BelongsToSegment(Point a, Point b)
        {

            return (Compare.RealMoreEq(this.x, a.x) && Compare.RealMoreEq(this.y, a.y) && Compare.RealLessEq(this.x, b.x) && Compare.RealLessEq(this.y, b.y));
        }
    }

    public class Vector
    /* ВЕКТОР 
    1) задать тип данных - вектор на плоскости(в декартовой системе координат, в полярной системе координат)
    2) операция перевода из декартовой системы координат в полярную и обратно
    3) построить вектор по координатам двух точек
    4) сумма двух векторов 
    5) разность двух векторов 
    6) умножение вектора на число
    7) скалярное произведение
    8) векторное произведение */
    {
        public double a, b;

        public Vector(Point p1, Point p2)
        {
            this.a = p2.x - p1.x;
            this.b = p2.y - p1.y;
        }
        public Vector()
        {
            Point p1 = new Point();
            Point p2 = new Point();
            this.a = p2.x - p1.x;
            this.b = p2.y - p1.y;
        }
        public Point Sum(Vector v2)
        {
            Point s = new Point(0, 0);
            s.x = this.a + v2.a;
            s.y = this.b + v2.b;
            return (s);
        }
        public Point Substr(Vector v2)
        {
            Point s = new Point(0, 0);
            s.x = v2.a - this.a;
            s.y = v2.b - this.b;
            return (s);
        }
        public Point Mult(double m)
        {
            Point pm = new Point(0, 0);
            pm.x = m * this.a;
            pm.y = m * this.b;
            return (pm);
        }
        public double MultScal(Vector v2)
        {
            double mscal;
            mscal = this.a * v2.a + this.b * v2.b;
            return mscal;
        }
        public double MultVect(Vector v2)
        {
            double mVect;
            mVect = this.a * v2.b - this.b * v2.a;
            return mVect;
        }
        public bool RealEq(double x, double y) //строго равно
        {
            const double eps = 1e-3;
            return (Math.Abs(x - y) < eps);
        }
        public bool RealLess(double x, double y) //строго меньше
        {
            const double eps = 1e-3;
            return (x - y < eps);
        }
        public double GetAngle(Vector v1) //угол в радианах
        {
            double rs, c;
            rs = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if (RealEq(rs, 0)) return 0;
            else
            {
                c = a / rs;
                if (RealEq(c, 0)) c = Math.PI / 2;
                else c = Math.Atan(Math.Sqrt(Math.Abs(1 - Math.Pow(c, 2))) / c);
                if (RealLess(c, 0)) c = Math.PI + c;
                if (RealLess(b, 0)) c = 2 * Math.PI - c;
                return c;
            }
        }
        public Point CartToPol()
        {
            Point pc = new Point(0, 0);
            pc.x = Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2));
            pc.y = GetAngle(this);
            return pc;
        }

    }
    class PolVect
    {
        public double r, angle;
        public PolVect()
        {
            InputCoord("Введите координаты вектора");
        }
        public void InputCoord(string s)
        {
            Console.WriteLine(s);
            this.r = Convert.ToDouble(Console.ReadLine());
            this.angle = Convert.ToDouble(Console.ReadLine());
        }
        public PolVect(double r, double angle)
        {
            this.r = r;
            this.angle = angle;

        }
        public Point PolToCart()
        {
            Point pc = new Point(0, 0);
            pc.x = this.r * Math.Cos(this.angle);
            pc.y = this.r * Math.Sin(this.angle);
            return pc;
        }
    }




    /*  ПРЯМАЯ
        1) задать тип данных прямая на плоскости +
        2) прямая по координатам двух точек +
        3) принадлежность точки прямой +
        4) существование точки пересчения двух прямых +
        5) точка пересечения двух прямых +                  */
    class Line
    {
        public double a, b, c;

        //определение уравнения прямой по координатам двух точек

        public Line(Point p1, Point p2)
        {
            this.a = p1.y - p2.y;
            this.b = p2.x - p1.x;
            this.c = -(p1.x * this.a + p1.y * this.b);
        }

        //существование точки пресечения двух прямых
        public bool CrossLine(Line L1)
        {
            double st;
            st = this.a * L1.b - L1.a * this.b;
            return (!Compare.RealEq(st, 0));
        }

        //точка пересечения двух прямых
        public Point PointCross(Line L1)
        {
            double st;
            Point pcr = new Point(0, 0);
            st = this.a * L1.b - L1.a * this.b;
            pcr.x = -(this.c * L1.b - L1.c * this.b) / st;
            pcr.y = -(this.a * L1.c - L1.a * this.c) / st;
            return pcr;
        }

        //принадежность точки прямой
        public bool AtSegm(Point p)
        {
            return (Compare.Equals(a * p.x + b * p.y + c, 0));
        }

        /*    6) точка пересечения двух отрезков
              7) Даны два отрезка, заданные координатами своих концов, определить их взаимное расположение.Результат равен:
                 0: отрезки пересекаются в одной точке и лежат на одной прямой;
                 1: не имеют пересчения и лежат на одной прямой
                 2: отрезки лежат на одной прямой и пересекаются более чем в одной точке
                 3: отрезки лежат на параллельных прямых
                 4: отрезки не лежат на одной прямой и не имеют точек пересечения
                 5: отрезки не лежат на одной прямой и пересекаются на концах отрезков
                 6: отрезки не лежат на одной прямой и пересекаются на концах отрезков и точка пересечения принадлежит одному из отрезков и является концом другого отрезка
                 7: отрезки не лежат на одной прямой и пересекаются в одной точке, не совпадающей ни с одним концом отрезков
        */

    }
    class Segm
    {
        Point fl, fr, sl, sr;
        public Segm(Point fl, Point fr, Point sl, Point sr)
        {
            this.fl = fl;
            this.fr = fr;
            this.sl = sl;
            this.sr = sr;
        }
        //взаимное расположение отрезков, расположенных на параллельных прямых
        public int SegmLineCross(Point sl, Point sr)
        {
            double minf, maxf, mins, maxs;
            Point ZeroPnt = new Point(0, 0);
            minf = Compare.RealMin(ZeroPnt.Dist(this.fl), ZeroPnt.Dist(this.fr));
            maxf = Compare.RealMax(ZeroPnt.Dist(this.fl), ZeroPnt.Dist(this.fr));
            mins = Compare.RealMin(ZeroPnt.Dist(sl), ZeroPnt.Dist(sr));
            maxs = Compare.RealMax(ZeroPnt.Dist(sl), ZeroPnt.Dist(sr));
            if (Compare.RealEq(minf, maxs) || Compare.RealEq(maxf, mins))
                return 0;
            else
            {
                if (Compare.RealMore(mins, maxf) || Compare.RealMore(minf, maxs))
                    return 1;
                else
                    return 2;
            }

        }

        //Взаимное расположение двух отрезков 
        public int SegmCross(Point sl, Point sr)
        {
            Line L1 = new Line(fl, fr);
            Line L2 = new Line(sl, sr);

            Compare num = new Compare();
            num.x = L1.a * L2.b;
            num.y = L1.c / L1.b;

            Point p = new Point(0, 0);

            if (L1.CrossLine(L2))  //если отрезки пересекаются
            {
                Point crossPoint = L1.PointCross(L2);

                if ((crossPoint.x == fl.x && crossPoint.y == fl.y || crossPoint.x == fr.x && crossPoint.y == fr.y) && (crossPoint.x == sl.x && crossPoint.y == sl.y || crossPoint.x == sr.x && crossPoint.y == sr.y))
                    return 5; //не лежат на одной прямой, пересекаются на концах 
                else
                {
                    if ((crossPoint.x == fl.x && crossPoint.y == fl.y || crossPoint.x == fr.x && crossPoint.y == fr.y) && crossPoint.BelongsToSegment(sl, sr) || (crossPoint.x == sl.x && crossPoint.y == sl.y) || (crossPoint.x == sr.x && crossPoint.y == sr.y) && crossPoint.BelongsToSegment(fl, fr))
                        return 6;   //не лежат на одной прямой, пересекаются в конце одного и не на конце второго 
                    else
                    {
                        if (crossPoint.BelongsToSegment(fl, fr) && crossPoint.BelongsToSegment(sl, sr))
                            return 7;   //не лежат на одной прямой, пересекаются не на концах +
                        else
                        {
                            return 4;   //не лежат на одной прямой, и не имеют точки пересечения +
                        }
                    }
                }
            }
            else
            {
                if (Compare.RealEq(num.x, L2.a * L1.b) && (!Compare.RealEq(num.y, L2.c / L2.b)))
                    return 3;  //лежат на параллельных прямых +
                else
                    return this.SegmLineCross(sl, sr);  //лежат на одной прямой +
            }
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point(2, 1);
            Point p2 = new Point(7, 1);
            Point p3 = new Point(7, 1);
            Point p4 = new Point(11, 1);
            Segm s1 = new Segm(p1, p2, p3, p4);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p1.x, p1.y, p2.x, p2.y, p3.x, p3.y, p4.x, p4.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s1.SegmCross(p3, p4));


            Point p5 = new Point(2, 2);
            Point p6 = new Point(6, 2);
            Point p7 = new Point(9, 2);
            Point p8 = new Point(13, 2);
            Segm s2 = new Segm(p5, p6, p7, p8);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p5.x, p5.y, p6.x, p6.y, p7.x, p7.y, p8.x, p8.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s2.SegmCross(p7, p8));

            Point p9 = new Point(2, 2);
            Point p10 = new Point(8, 2);
            Point p11 = new Point(6, 2);
            Point p12 = new Point(11, 2);
            Segm s3 = new Segm(p9, p10, p11, p12);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p9.x, p9.y, p10.x, p10.y, p11.x, p11.y, p12.x, p12.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s3.SegmCross(p11, p12));

            Point p13 = new Point(1, 2);
            Point p14 = new Point(4, 2);
            Point p15 = new Point(2, 1);
            Point p16 = new Point(4, 1);
            Segm s4 = new Segm(p13, p14, p15, p16);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p13.x, p13.y, p14.x, p14.y, p15.x, p15.y, p16.x, p16.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s4.SegmCross(p15, p16));

            Point p17 = new Point(1, 2);
            Point p18 = new Point(3, 4);
            Point p19 = new Point(4, 1);
            Point p20 = new Point(6, 2);
            Segm s5 = new Segm(p17, p18, p19, p20);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p17.x, p17.y, p18.x, p18.y, p19.x, p19.y, p20.x, p20.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s5.SegmCross(p19, p20));

            Point p21 = new Point(1, 2);
            Point p22 = new Point(1, 6);
            Point p23 = new Point(1, 2);
            Point p24 = new Point(7, 2);
            Segm s6 = new Segm(p21, p22, p23, p24);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p21.x, p21.y, p22.x, p22.y, p23.x, p23.y, p24.x, p24.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s6.SegmCross(p23, p24));

            Point p25 = new Point(1, 3);
            Point p26 = new Point(4, 6);
            Point p27 = new Point(6, 1);
            Point p28 = new Point(3, 5);
            Segm s7 = new Segm(p25, p26, p27, p28);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p25.x, p25.y, p26.x, p26.y, p27.x, p27.y, p28.x, p28.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s7.SegmCross(p27, p28));

            Point p29 = new Point(2, 2);
            Point p30 = new Point(6, 4);
            Point p31 = new Point(3, 1);
            Point p32 = new Point(5, 5);
            Segm s8 = new Segm(p29, p30, p31, p32);
            Console.WriteLine("Отрезки с координатами p1 = {0:0},{1:0}  p2 = {2:0},{3:0} p3 = {4:0},{5:0} p4 = {6:0},{7:0}", p29.x, p29.y, p30.x, p30.y, p31.x, p31.y, p32.x, p32.y);
            Console.WriteLine("Расположение двух отрезков: {0:G}", s8.SegmCross(p31, p32));
            Console.Read();
        }
    }
}