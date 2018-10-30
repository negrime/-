using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{

    class Basa  //базовые функции
    {
        private const double E = 1E-5; //эпсилон

        //функция сравнения двух вещественных чисел, возвращает 0 если числа равны
        // 1 - если первое число больше, -1 - если второе число больше
        // Строго больше Comparison(a,b) > 0
        // Строго равно Comparison(a,b) = 0
        // Строго меньше Comparison(a,b) < 0
        // Больше или равно Comparison(a,b) > -1
        // Меньше или равно Comparison(a,b) < 1
        static public int Comparison(double d1, double d2)
        {
            double difference = d1 - d2;    //разность первого и второго числа
            if (Math.Abs(difference) <= E)   //если разность по модулю меньше эпсилона
                return 0;   //считать числа равными 
            //иначе
            if (difference > 0) //если разница больше 0 
                return 1;   //то первое число больше
            //иначе
            return -1;  //второе чило больше             
        }

        //Максимальное из двух вещественных чисел
        static public double Max(double a, double b)
        {
            if (Comparison(a, b) > 0)
                return a;
            return b;
        }

        //Минимальное из двух вещественных чисел
        static public double Min(double a, double b)
        {
            if (Comparison(a, b) > 0)
                return b;
            return a;
        }
    }

    class Point //класс точка (в декартовой системе координат)
    {
        public double x, y;    //координаты точки

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }

        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }

        }

        //конструктор класса
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display()
        {
            Console.WriteLine("x = {0} y = {1}", x, y);
        }

        //точка с координатами (0,0)
        public static Point ZeroPnt = new Point(0, 0);

        //проверка двух точек на совпадение 
        static public bool EqPoint(Point A, Point B)
        {
            return (Basa.Comparison(A.x, B.x) == 0) && (Basa.Comparison(A.y, B.y) == 0);
        }
        //вычисление расстояния между двумя точками на плоскости
        static public double Dist(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }

        public static explicit operator Point(double v)
        {
            throw new NotImplementedException();
        }
    }

    class Vector //класс вектор
    {
        private bool Cartesian; //переменная отвечает за то в какой системе задан вектор
        //вектор в декартовой системе координат
        public double x, y, z;
        //вектор в полярной системе координат
        private double r;   //расстояние
        private double p;   //угол
        //конструктор вектора 
        public Vector(double x, double y, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            Cartesian = true;
        }
        //вывод вектора
        static public void OutPutVector(Vector V)
        {
            if (V.Cartesian)
                Console.WriteLine("({0};{1}" + ((Basa.Comparison(V.z, 0) == 0) ? ")" : ";{2})"), V.x, V.y, V.z);
            else
                Console.WriteLine("r ={0}; p = {1}", V.r, V.p);

        }

        //операция перевода из декартовой системы координат в полярную 
        public void CartesianToPolar(Vector V)
        {
            V.r = Math.Sqrt(V.x * V.x + V.y * V.y); //расстояние
            V.p = (Basa.Comparison(V.r, 0) == 0) ? 0 : Math.Asin(V.y / Math.Sqrt(V.r));  //угол
            Cartesian = false;
        }

        //операция перевода из полярной системы координат в декартову 
        public void PolarToCartesian(Vector V)
        {
            V.x = V.r * Math.Cos(p);
            V.y = V.r * Math.Sin(p);
            Cartesian = true;
        }

        // построить вектор по координатам двух точек
        public Vector(Point A, Point B)
        {
            this.x = B.X - A.X;
            this.y = B.Y - A.Y;
            Cartesian = true;
        }

        //сумма векторов
        static public Vector Addition(Vector V1, Vector V2)
        {
            Vector V3 = new Vector(V1.x + V2.x, V1.y + V2.y);
            return V3;
        }
        //разность двух векторов 
        static public Vector Subtraction(Vector V1, Vector V2)
        {
            Vector V3 = new Vector(V1.x - V2.x, V1.y - V2.y);
            return V3;
        }
        //умножение вектора на число
        static public void Multiplication(Vector V1, double k)
        {
            V1.x = V1.x * k;
            V1.y = V1.y * k;
        }
        //скалярное произведение двух векторов
        static public double Scalar(Vector V1, Vector V2)
        {
            return V1.x * V2.x + V1.y * V2.y;
        }
        //векторное произведение двух векторов - возвразает трехмерный вектор
        static public Vector VectorMultiplication(Vector V, Vector W)
        {
            Vector result = new Vector(0, 0)
            {
                z = V.x * W.y - V.y * W.x
            };
            return result;
        }

        static public double VectorMultiplication2(Vector V, Vector W)
        {
            return V.x * W.y - V.y * W.x;
        }

    }

    //---------------------------------------------------------------------------------
    //Прямая линия и отрезок прямой
    //1) Задать тип данных - прямая на плоскости
    //2) Прямая по координатам двух точек
    //3) Принадлежность точки прямой
    //4) Существование точки пересечения двух прямых   
    //5) Точка пересечения двух прямых
    //6) Точка пересечения двух отрезков
    //7) Даны два отрезка на плоскости, заданные координатами своих концов.
    //   определить их взаимное расположение   
    //---------------------------------------------------------------------------------
    //класс прямая
    class Line
    {
        private double A, B, C; //коэффициенты уравнения прямой A*x + B*y + C = 0 

        //Прямая по координатам двух точек
        public static Line PointsToLine(Point V, Point W)
        {
            Line res = new Line
            {
                A = V.Y - W.Y,
                B = W.X - V.X
            };

            res.C = -(V.X * res.A + V.Y * res.B);
            return res;
        }

        //принадлежность точки прямой
        public static bool AtLine(Point P, Line L)
        {
            return (Basa.Comparison((L.A * P.X) + (L.B * P.Y) + L.C, 0) == 0);
        }

        //существование точки пересечения двух прямых
        public static bool CrossLine(Line L1, Line L2)
        {
            return !(Basa.Comparison(L1.A * L2.B - L2.A * L1.B, 0) == 0);
        }

        //Точка пересечения двух прямых
        public static Point Line2ToPoint(Line L1, Line L2)
        {
            //  if (!CrossLine(L1, L2)) return Point.ZeroPnt; //если точки пересечения не существует - вернуть null
            //иначе выполняется следующий код
            double st = L1.A * L2.B - L2.A * L1.B;
            double x = (L1.C * L2.B - L2.C * L1.B) / st;
            double y = (L1.A * L2.C - L2.A * L1.C) / st;
            return new Point(x, y);
        }
        //проверка принадлежности точки отрезку 
        public static bool AtSegm(Point A, Point B, Point P)
        {
            if (Point.EqPoint(A, B)) //точки A и B совпадают 
            {
                return Point.EqPoint(A, P); // совпадение точек A и P 
            }
            else
            {
                return (Basa.Comparison((P.X - A.X) * (B.Y - A.Y), (P.Y - A.Y) * (B.X - A.X)) == 0) &&
                (((Basa.Comparison(P.X, A.X) > -1) && (Basa.Comparison(B.X, P.X) > -1)) ||
                ((Basa.Comparison(P.Y, B.Y) > -1) && (Basa.Comparison(A.X, P.X) > -1)));
            }
        }

        //точка пересечения двух отрезков, если точки пересечения не существует, то возвращает точку (0,0)
        public static Point FindPointCross(Point fL, Point fR, Point sL, Point sR)
        {
            Line L1 = PointsToLine(fL, fR); //прямая, проходящая через концы первого отрезка
            Line L2 = PointsToLine(sL, sR); //прямая, проходящая через концы второго отрезка 
            if (CrossLine(L1, L2)) //если точка пересечения существует
                return Line2ToPoint(L1, L2); //вернуть точку пересечения
            return Point.ZeroPnt;  //иначе вернуть точку (0,0)
        }

        //вспомогательная функция
        //Отрезки находятся на одной прямой
        //Проверака их взаиного расположения.
        //Результат равен 0 - отрезки пересекаются в одной точке
        //Результат равен 1 - не имеют точек пересечения
        //Результат равен 2 - есть пересечения более чем в одной точке
        public static int SegmLineCross(Point fL, Point fR, Point sL, Point sR)
        {
            double Minf = Basa.Min(Point.Dist(fL, Point.ZeroPnt), Point.Dist(fR, Point.ZeroPnt));
            double Maxf = Basa.Max(Point.Dist(fL, Point.ZeroPnt), Point.Dist(fR, Point.ZeroPnt));
            double Mins = Basa.Min(Point.Dist(sL, Point.ZeroPnt), Point.Dist(sR, Point.ZeroPnt));
            double Maxs = Basa.Max(Point.Dist(sL, Point.ZeroPnt), Point.Dist(sR, Point.ZeroPnt));
            if ((Basa.Comparison(Minf, Maxs) == 0) || (Basa.Comparison(Maxf, Mins) == 0))
                return 0;
            if ((Basa.Comparison(Mins, Maxf) > 0) || (Basa.Comparison(Minf, Maxs) > 0))
                return 1;
            return 2;
        }
        //определение взаимного положения двух отрезков на плоскости
        /// <summary>
        /// Результат равен 0 - пересекаются в одной точки и лежат на одной прямой
        /// Результат равен 1 - не имеют пересечения и лежат на одной прямой 
        /// Результат равен 2 - пересекаются более чем в одной точке и лежат на одной прямой
        /// Результат равен 3 - лежат на параллельных прямых
        /// Результат равен 4 - не лежат на одной прямой и не имеют точки пересечения
        /// Результат равен 5 - отрезки не лежат на одной прямой и пересекаются на концах ОТРЕЗКОВ
        /// Результат равен 6 - не лежат на одной прямой, точка пересечения пренадлежит одному из отрезков и является концом другого
        /// Результат равен 7 - не лежат на одной прямой и пересекаютя в одной точке (не на концвх отрезков)
        /// </summary>
        /// <param name="fL">левый конец первого отрезка</param>
        /// <param name="fR">правый конец первого отрезка</param>
        /// <param name="sL">левый конец второго отрезка</param>
        /// <param name="sR">правый конец вторго отркзка</param>
        /// <returns></returns>
        public static int SegmCross(Point fL, Point fR, Point sL, Point sR)
        {
            Point rs;
            Line L1 = PointsToLine(fL, fR);
            Line L2 = PointsToLine(sL, sR);
            if (CrossLine(L1, L2))
            {
                rs = Line2ToPoint(L1, L2);

                if (Point.EqPoint(rs, fL) || Point.EqPoint(rs, fR) || Point.EqPoint(rs, sL) || Point.EqPoint(rs, sR))
                    return 5;

                if (AtSegm(fL, fR, rs) && AtSegm(sL, sR, rs))
                    return 7;

                if (AtSegm(fL, fR, rs) || AtSegm(sL, sR, rs))
                    return 6;

                return 4;
            }
            else
            {
                if ((Basa.Comparison(L1.A * L2.B, L2.A * L1.B) == 0) && (!(Basa.Comparison(L1.C, L2.C) == 0)))
                    return 3;
                return SegmLineCross(fL, fR, sL, sR);
            }
        }

    }
    //ТРЕУГОЛЬНИК
    //1) проверить существование треугольника по 3 длинам сторон
    //2) проверить существование треугольника по 3 координатам вешин 
    //3) площадь треугольника ( 2 способа: формула герона, векторное произведение)
    //4) периметр треугольника
    //5) замечательные линии: медиана, биссектриса, высота
    //6) на заданном множестве точек найти треугольник с меньшей площадью
    class Triangle
    {
        //длины сторон
        private double a;
        private double b;
        private double c;

        //конструктор класса
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //конструктор через точки
        public Triangle(Point A, Point B, Point C)
        {
            this.a = Point.Dist(A, B);
            this.b = Point.Dist(B, C);
            this.c = Point.Dist(C, A);
        }

        //проверить существование треугольника по 3 длинам сторон
        public static bool IsTrian(double a, double b, double c)
        {
            return (Basa.Comparison(a + b, c) > 0) && (Basa.Comparison(a + c, b) > 0) && (Basa.Comparison(c + b, a) > 0);
        }

        //проверить существование треугольника по 3 координатам вешин
        public static bool IsTrian(Point A, Point B, Point C)
        {
            return (Basa.Comparison(A.x, B.x) != 0) && (Basa.Comparison(B.x, C.x) != 0) &&
                   (Basa.Comparison(A.y, B.y) != 0) && (Basa.Comparison(B.y, C.y) != 0);
        }
        //периметр треугольника
        public double Perimetr()
        {
            return (this.a + this.b + this.c);

        }
        //площадь треугольника формула герона
        public double SqGeron()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }

        //площадь треугольника через векторное произведение
        public static double SqVector(Point A, Point B, Point C)
        {
            Vector AB = new Vector(A, B);
            Vector AC = new Vector(A, C);
            Vector S = Vector.VectorMultiplication(AB, AC);

            return Math.Abs((S.z / 2));
        }

        //вычисление высоты, проведенной из вершины, противоположной стороне с длиной а
        public double GetHeight(int cas)
        {

            {
                if (1 == cas)
                    return (2 * SqGeron() / a);
                if (2 == cas)
                    return (2 * SqGeron() / b);
                if (3 == cas)
                    return (2 * SqGeron() / c);

                return 0;

            }
        }

        //вычисление длины медианы, проведенной из вершины, противоположной стороне с длиной а
        public double GetMed(int x)
        {

            double a2 = Math.Pow(this.a, 2);
            double b2 = Math.Pow(this.b, 2);
            double c2 = Math.Pow(this.c, 2);
            if (1 == x)
                return Math.Sqrt(2 * (b2 + c2) - a2) / 2;
            if (2 == x)
                return Math.Sqrt(2 * (a2 + c2) - b2) / 2;

            if (3 == x)
                return Math.Sqrt(2 * (a2 + b2) - c2) / 2;
            return 0;
        }

        //вычисление биссектрисы, проведенной из вершины, противоположной стороне с длиной а
        public double GetBis(int cas)
        {
            double p = Perimetr() / 2;
            if (1 == cas)
                return 2 * Math.Sqrt(this.b * this.c * p * (p - a)) / (b + c);
            if (2 == cas)
                return 2 * Math.Sqrt(this.b * this.a * p * (p - c)) / (b + a);
            if (3 == cas)
                return 2 * Math.Sqrt(this.a * this.c * p * (p - b)) / (a + c);
            return 0;
        }

        //на заданном множестве точек найти треугольник с меньшей площадью
        public static Triangle MinSqTrinagel(Point[] mas, int size)
        {
            Point A = mas[0];
            Point B = mas[1];
            Point C = mas[2];

            //переменная - минимальная площадь
            double SqMin = SqVector(A, B, C);

            int i = 0;

            while (i < size)
            {
                int j = i + 1;

                while (j < size)
                {
                    int t = j + 1;

                    while (t < size)
                    {
                        double S = SqVector(mas[i], mas[j], mas[t]);
                        if (Basa.Comparison(S, SqMin) < 0)
                        {
                            SqMin = S;
                            A = mas[i];
                            B = mas[j];
                            C = mas[t];
                        }
                        t++;
                    }
                    j++;
                }
                i++;
            }

            return new Triangle(A, B, C);

        }

        //вывод информации о треугольнике
        public void OutoutInfo()
        {
            Console.WriteLine("a = {0}; b = {1}; c = {2}", this.a, this.b, this.c);
        }

    }

    //основная программа
    class Program
    {     
        //главная функция программы
        static void Main(string[] args)
        {
            Point A = new Point(5, 2);
            Point B = new Point(7, 2);

            Line l = new Line();
        //    l = Line.PointsToLine(A, B);

            //if (Line.AtLine(new Point(2, 3), l))
            if(Line.AtSegm(A, B, new Point(6, 2)))
            {
                Console.WriteLine("Nikita pidors");
            }
           // Console.WriteLine("Nikita pidors");
            Console.WriteLine(l);
            Console.Read();

            

        }
    }
}
