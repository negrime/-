using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg
{
    class Basa
    {
        private const double E = 1E-5;

        //Сравнение 2х чисел 
        static public int Comparison(double d1, double d2)
        {
            double dif = d1 - d2;
            if (Math.Abs(dif) <= E)
                return 0; // 0 - числа равны
            if (dif < 0)
                return -1; //-1 - d1 меньше, чем d2
            return 1; //1 - d1 больше, чем d2
        }

        //Максимальное из 2х чисел
        static public double Max(double d1, double d2)
        {
            if (Comparison(d1, d2) > 0)
                return d1; //Если d1 больше d2 вернуть d1
            return d2; //иначе вернуть d2
        }

        //Минимальное из 2х чисел
        static public double Min(double d1, double d2)
        {
            if (Comparison(d1, d2) > 0)
                return d2;
            return d1;
        }
    }

    class Point //класс точки
    {
        public double x, y; //координаты точки

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

        //конструктор
        public Point(double x1, double y1)
        {
            x = x1;
            y = y1;
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

        //вычисление расстояния между двумя точками
        static public double Dist(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
        }

    }



    class Vector //класс вектор
    {
        private bool Cartesian; //переменная отвечает за то в какой системе задан вектор
        //вектор в декартовой системе координат
        public double x, y, z;
        //вектор в полярной системе координат
        public double r;   //расстояние
        public double p;   //угол
        //конструктор вектора 
        public Vector(double r, double p)
        {
            this.r = r;
            this.p = p;
            Cartesian = false;
            /* this.x = x;
             this.y = y;
             this.z = z;
             Cartesian = true;*/
        }

        public void VectorP(double r, double p)
        {
            this.r = r;
            this.p = p;
            Cartesian = false;
        }
        //вывод вектора
        public void OutPutVector()
        {
            //if (Cartesian)
            Console.WriteLine("_@_");
                Console.WriteLine("({0:f4},{1:f4})", this.x, this.y);
            //Console.WriteLine("({0};{1}" + ((Basa.Comparison(z, 0) == 0) ? ")" : ";{2})"), x, y, z);
            //else
                //Console.WriteLine("@@@@@");
                //Console.WriteLine("r ={0}; p = {1}", r, p);
        }

        //операция перевода из декартовой системы координат в полярную 
        public static void CartesianToPolar(Vector V)
        {
            V.r = Math.Sqrt(V.x * V.x + V.y * V.y); //расстояние
            if (Basa.Comparison(V.r, 0) == 0)
                V.p = 0;
            else
                V.p = Math.Atan2(V.y, V.x);  //угол
            V.Cartesian = false;
        }

        //операция перевода из полярной системы координат в декартову 
        public void PolarToCartesian()
        {
            //V.p = V.p * 57.2958;
            this.x = r * Math.Cos(p);
            Console.WriteLine("@{0:f4}", Math.Cos(p));
            Console.WriteLine("@x{0:f4}", x);
            this.y = r * Math.Sin(p);
            Console.WriteLine("@{0:f4}", Math.Sin(p));
            Console.WriteLine("@y{0:f4}", y);

            Cartesian = true;
        }

        // построить вектор по координатам двух точек
        public Vector(Point A, Point B)
        {
            x = B.X - A.X;
            y = B.Y - A.Y;
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
    }

    //класс прямая
    class Line
    {
        public double A, B, C; //коэффициенты уравнения прямой A*x + B*y + C = 0

        //Прямая по координатам двух точек
        public Line(Point p1, Point p2)
        {
            this.A = p1.y - p2.y;
            this.B = p2.x - p1.x;
            this.C = -(p1.x * this.A + p1.y * this.B);
        }

        //принадлежность точки прямой
        public bool InLine(Point P)
        {
            return (Basa.Comparison((this.A * P.X) + (this.B * P.Y) + this.C, 0) == 0);
        }

        //существование точки пересечения двух прямых
        public static bool CrossLine(Line L1, Line L2)
        {
            return (Basa.Comparison(L1.A * L2.B - L2.A * L1.B, 0) != 0);
        }

        //Точка пересечения двух прямых
        public static Point LinesPoint(Line L1, Line L2)
        {
            double st = L1.A * L2.B - L2.A * L1.B;
            double x = -(L1.C * L2.B - L2.C * L1.B) / st;
            double y = -(L1.A * L2.C - L2.A * L1.C) / st;
            return new Point(x, y);
        }

        //точка пересечения двух отрезков, если точки пересечения не существует, то возвращает точку (0,0)
        public static Point FindPointCross(Point fL, Point fR, Point sL, Point sR)
        {
            Line L1 = new Line(fL, fR); //прямая, проходящая через концы первого отрезка
            Line L2 = new Line(sL, sR); //прямая, проходящая через концы второго отрезка 
            if (CrossLine(L1, L2)) //если точка пересечения существует
                return LinesPoint(L1, L2); //вернуть точку пересечения
            return Point.ZeroPnt;  //иначе вернуть точку (0,0)
        }

        //проверка принадлежности точки отрезку
        public static bool AtSegm(Point A, Point B, Point P)
        {
            if (Point.EqPoint(A, B)) //если точки A и B совпадают то  
            {
                return Point.EqPoint(A, P);  //результат определяется совпадением точек  A и P
            }
            else //нетривиальный случай
            {
                return (((P.x - A.x)*(B.y - A.y) - (P.y - A.y)*(B.x - A.x)) == 0) && ((P.x > A.x) && (P.x < B.x) || (P.x < A.x) && (P.x > B.x));
            }
        }

        //Отрезки находятся на одной прямой
        //Результат равен 0 - отрезки пересекаются в одной точке и лежат на одной прямой
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



        /*Результат равен 0 - пересекаются в одной точки и лежат на одной прямой
     Результат равен 1 - не имеют пересечения и лежат на одной прямой 
     Результат равен 2 - пересекаются более чем в одной точке и лежат на одной прямой
     Результат равен 3 - лежат на параллельных прямых
     Результат равен 4 - не лежат на одной прямой и не имеют точки пересечения
     Результат равен 5 - отрезки не лежат на одной прямой и пересекаются на концах ОТРЕЗКОВ
     Результат равен 6 - не лежат на одной прямой, пересекаются на концах отрезков и точка пересечения принадлежит одному из отрезков и является концом другого отрезка
     Результат равен 7 - не лежат на одной прямой и пересекаютя в одной точке (не на концвх отрезков)
        */
        public static int SegmCross(Point fL, Point fR, Point sL, Point sR)
        {
            Point rs;
            Line L1 = new Line(fL, fR);
            Line L2 = new Line(sL, sR);
            if (CrossLine(L1, L2)) //существование точки пересечения
            {
                rs = LinesPoint(L1, L2);

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

    class Triangle
    {
        //длины сторон
        private double a;
        private double b;
        private double c;

        //конструктор
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

        //вывод информации о треугольнике
        public void Info()
        {
            Console.WriteLine("a = {0}; b = {1}; c = {2}", this.a, this.b, this.c);
        }

        //проверка сущестоввания треугольника
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
            Vector S = Vector.VectorMultiplication(AB, AC);//умножаем вектора

            return Math.Abs((S.z / 2));
        }

        //вычисление медианы к 3 сторонам
        public void GetMed()
        {

            double a2 = Math.Pow(this.a, 2);
            double b2 = Math.Pow(this.b, 2);
            double c2 = Math.Pow(this.c, 2);
                Console.WriteLine("Медиана к стороне a = {0:f4}", Math.Sqrt(2 * (b2 + c2) - a2) / 2);
                Console.WriteLine("Медиана к стороне b = {0:f4}", Math.Sqrt(2 * (a2 + c2) - b2) / 2);
                Console.WriteLine("Медиана к стороне c = {0:f4}", Math.Sqrt(2 * (a2 + b2) - c2) / 2);
        }

        //вычисление биссектрисы к 3 сторонам 
        public void GetBis()
        {
            double p = Perimetr() / 2;
                Console.WriteLine("Биссектриса к стороне a = {0:f4}", 2 * Math.Sqrt(this.b * this.c * p * (p - a)) / (b + c));
                Console.WriteLine("Биссектриса к стороне b = {0:f4}", 2 * Math.Sqrt(this.b * this.a * p * (p - c)) / (b + a));
                Console.WriteLine("Биссектриса к стороне c = {0:f4}", 2 * Math.Sqrt(this.a * this.c * p * (p - b)) / (a + c));
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
                    int z = j + 1;

                    while (z < size)
                    {
                        double S = SqVector(mas[i], mas[j], mas[z]);
                        if (Basa.Comparison(S, SqMin) < 0)
                        {
                            SqMin = S;
                            A = mas[i];
                            B = mas[j];
                            C = mas[z];
                        }
                        z++;
                    }
                    j++;
                }
                i++;
            }
            return new Triangle(A, B, C);
        }

    }



    class Polygon
    {
        public enum PointInPolygon //Положение точки в многоугольнике
        {
            INSIDE, // Внутри
            OUTSIDE, // Снаружи
            BOUNDERY // На многоугольнике
        }

        private enum EdgeType//Положение ребра
        {
            TOUCHING, // Лежит на прямой
            CROSSING, // Входит 
            INESSENTIAL // Не входит в область прямой
        }

        private enum PointOverEdge//Положение точки относительно отрезка
        {
            LEFT, // Слева
            RIGHT, // Справа
            BETWEEN, // Между
            OUTSIDE // Не на отрезке
        }
        //Список точек
        public Point[] A;
        public int size;
        //Конструктор класса
        public Polygon(params Point[] mas)
        {
            size = mas.Length;
            A = new Point[size];
            for (int i = 0; i < size; i++)
            {
                A[i] = mas[i];
            }
        }

        //является ли заданный многоугольник простым
        public bool IsPoligonSimp()
        {
            bool res = true;
            int i = 0;
            while ((i < size - 1) && res)
            {
                int j = i + 1;
                while ((j < size) && res)
                {
                    // Вычисляем положение двух отрезков на многоугольника
                    switch (Line.SegmCross(A[i], A[i + 1], A[j], A[(j + 1) % size]))
                    /*Результат равен 0 - пересекаются в одной точки и лежат на одной прямой
     Результат равен 1 - не имеют пересечения и лежат на одной прямой 
     Результат равен 2 - пересекаются более чем в одной точке и лежат на одной прямой
     Результат равен 3 - лежат на параллельных прямых
     Результат равен 4 - не лежат на одной прямой и не имеют точки пересечения
     Результат равен 5 - отрезки не лежат на одной прямой и пересекаются на концах ОТРЕЗКОВ
     Результат равен 6 - не лежат на одной прямой, пересекаются на концах отрезков и точка пересечения принадлежит одному из отрезков и является концом другого отрезка
     Результат равен 7 - не лежат на одной прямой и пересекаютя в одной точке (не на концвх отрезков)
        */
                    {
                        case 0:
                        case 2:
                        case 6:
                        case 7: res = false; break;
                    }
                    j++;
                }
                i++;
            }
            return res;
        }

        private PointOverEdge Classify(Point p, Point v, Point w) //положение точки p относительно отрезка vw
        {
            //коэффициенты уравнения прямой
            double a = v.Y - w.Y;
            double b = w.X - v.X;
            double c = v.X * w.Y - w.X * v.Y;

            //подставим точку в уравнение прямой
            double f = a * p.X + b * p.Y + c;
            if (Basa.Comparison(f, 0.0) > 0)
                return PointOverEdge.RIGHT; //точка лежит справа от отрезка
            if (Basa.Comparison(f, 0.0) < 0)
                return PointOverEdge.LEFT; //слева от отрезка

            double minX = Math.Min(v.X, w.X);
            double maxX = Math.Max(v.X, w.X);
            double minY = Math.Min(v.Y, w.Y);
            double maxY = Math.Max(v.Y, w.Y);

            if ((Basa.Comparison(minX, p.X) <= 0) &&
                (Basa.Comparison(p.X, maxX) <= 0) &&
                (Basa.Comparison(minY, p.Y) <= 0) &&
                (Basa.Comparison(p.Y, maxY) <= 0))
                return PointOverEdge.BETWEEN; //точка лежит на отрезке
            return PointOverEdge.OUTSIDE; //точка лежит на прямой, но не на отрезке
        }

        private EdgeType edgeType(Point a, Point v, Point w) //тип ребра vw для точки a 
        {
            switch (Classify(a, v, w))
            {
                case PointOverEdge.LEFT:
                    return ((v.Y < a.Y) && (a.Y <= w.Y)) ? EdgeType.CROSSING : EdgeType.INESSENTIAL;
                case PointOverEdge.RIGHT:
                    return ((w.Y < a.Y) && (a.Y <= v.Y)) ? EdgeType.CROSSING : EdgeType.INESSENTIAL;
                case PointOverEdge.BETWEEN:
                    return EdgeType.TOUCHING;
                default:
                    return EdgeType.INESSENTIAL;
            }
        }

        public PointInPolygon pointInPolygon(Point a) //положение точки в многоугольнике
        {
            bool parity = true;
            for (int i = 0; i < A.Length; i++)
            {
                Point v = A[i];
                Point w = A[(i + 1) % A.Length];

                switch (edgeType(a, v, w))
                {
                    case EdgeType.TOUCHING:
                        return PointInPolygon.BOUNDERY;
                    case EdgeType.CROSSING:
                        parity = !parity;
                        break;
                }
            }

            return parity ? PointInPolygon.OUTSIDE : PointInPolygon.INSIDE;
        }

        ///Вычислить площадь простого плоского многоугольника
        public double Square()
        {
            if (this.size < 3)
                return 0;
            double sc = A[0].x * (A[1].y - A[size - 1].y) + A[size - 1].x * (A[0].y - A[size - 2].y);
            for (int i = 1; i < size - 1; i++)
            {
                sc = sc + A[i].x * (A[i + 1].y - A[i - 1].y);
            }
            return Math.Abs(sc / 2);
        }

        //нахождение длин сторон по трем точкам
        void LenTring(ref double a1, ref double b1, ref double c1, Point P1, Point P2, Point P3)
        {
            c1 = Point.Dist(P1, P2);
            b1 = Point.Dist(P3, P2);
            a1 = Point.Dist(P3, P1);
        }
        //Косинус по трем сторонам
        double Cos(double a1, double b1, double c1)
        {
            return (-a1 * a1 + b1 * b1 + c1 * c1) / (2 * b1 * c1);
        }

        //проверка выпуклости многоугольника
        public bool IsPoligonConvex()
        {
            int n = size;
            Double summAng = 0.0;
            Double cos;
            Double a1 = 0, b1 = 0, c1 = 0;

            for (int i = 0; i < n - 2; i++)
            {
                LenTring(ref a1, ref b1, ref c1, A[i + 1], A[i], A[i + 2]);
                cos = Cos(b1, a1, c1);
                //Console.WriteLine(cos);
                summAng += Math.Acos(cos);
            }

            LenTring(ref a1, ref b1, ref c1, A[n - 1], A[n - 2], A[0]);
            cos = Cos(b1, a1, c1);
            //Console.WriteLine(cos);
            summAng += Math.Acos(cos);

            LenTring(ref a1, ref b1, ref c1, A[0], A[n - 1], A[1]);
            cos = Cos(b1, a1, c1);
            //Console.WriteLine(cos);
            summAng += Math.Acos(cos);

            //Console.WriteLine(summAng);
            return Basa.Comparison(summAng, Math.PI * (n - 2)) == 0;
        }
    }





    //ВЫПУКЛАЯ ОБОЛОЧКА
    //1)построить минимальную выпуклую оболочку для множества точек
    //на плоскости(алгоритм Грэхема И алгоритм Джарвиса). 
    //Проверить построенный многоугольник на выпуклость.Проверить что все точки принадлежат
    //построенному многоугольнику.

    class Convex
    {
        Point p0;  //p0 - точка с минимальной координатой у или самая левая из таких точек при наличии совпадений
        public int sizeP; //кол-во точек выпуклой оболочки
        public int size;  // количество точек исходного множества
        Point[] Q; // множество точек для которых строится оболочка

        //конструктор класса
        public Convex(Point[] mas)
        {
            size = mas.Length;
            Q = new Point[size];
            for (int i = 0; i < size; i++) { Q[i] = mas[i]; }
            p0 = Q[0];
            sizeP = size - 1;
        }

        //Вектороное произведение
        // через векторное произведение определяем поворот
        //(если величина отрицательная - поворот против часовой стрелки, и наоборот)
        static double vect(Point a1, Point a2, Point b1, Point b2)
        {
            return (a2.x - a1.x) * (b2.y - b1.y) - (b2.x - b1.x) * (a2.y - a1.y);
        }

        //Квадрат длины вектора
        static double dist2(Point a1, Point a2)
        {
            return Math.Pow(a2.x - a1.x, 2) + Math.Pow(a2.y - a1.y, 2);
        }

        //Построение выпуклой оболочки Джарвиса

        static public Point[] Solve(Point[] a, ref int k)
        {
            Point[] b = new Point[a.Length + 1];
            int i, j, m;
            int n = a.Length;
            //ищем правую нижнюю точку
            m = 0;
            for (i = 0; i < n; i++)
                if (a[i].y < a[m].y)
                    m = i;
                else if ((a[i].y == a[m].y) && (a[i].x > a[m].x)) m = i;
            //запишем ее в массив b и переставим на первое место в массиве a
            b[0] = a[m]; a[m] = a[0]; a[0] = b[0];
            k = 0;
            int min = 1;

            do
            {
                //ищем очередную вершину оболочки
                for (j = 1; j < n; j++)
                    if ((vect(b[k], a[min], b[k], a[j]) < 0) ||
                       ((vect(b[k], a[min], b[k], a[j]) == 0) &&
                       (dist2(b[k], a[min]) < dist2(b[k], a[j]))))
                        min = j;
                k++;
                //записана очередная вершина
                b[k] = a[min];
                min = 0;
            } while (!((b[k].x == b[0].x) && (b[k].y == b[0].y)));//пока ломаная не замкнется
            return b;
        }

        //алгоритм Грэхема

        Point[] sort(Point[] P) // сортирует все точки множества в порядке возрастания 
        //полярного угла по отнощению к р0
        {
            bool t = true;
            while (t)
            {
                t = false;
                for (int j = 0; j < sizeP - 1; j++)
                    if (Basa.Comparison(angle(p0, P[j], P[j + 1]), 0) > 0)//по часовой
                    {
                        Point tmp = new Point(P[j].x, P[j].y);
                        P[j] = P[j + 1];
                        P[j + 1] = tmp;
                        t = true;

                    }
                    else
                    if (Basa.Comparison(angle(p0, P[j], P[j + 1]), 0) == 0)
                    {
                        if (Basa.Comparison(P[j].X, P[j + 1].X) > 0)
                        {
                            for (int k = j + 2; k < sizeP; k++)
                                P[k - 1] = P[k];
                            sizeP--;
                            t = true;
                        }
                        else
                            if (Basa.Comparison(P[j + 1].X, P[j].X) > 0)
                            {
                                for (int k = j + 1; k < sizeP; k++)
                                    P[k - 1] = P[k];
                                sizeP--;
                                t = true;
                            }

                    }
            }
            return P;
        }

        //считает полярный угол данной точки по отнощению к р0
        double alpha(Point t)
        {
            t.X -= p0.X;
            t.Y = p0.Y - t.Y;
            double alph;
            if (t.X == 0) alph = Math.PI / 2;
            else
            {

                if (t.Y == 0) alph = 0;
                else alph = Math.Atan(Convert.ToDouble(t.Y) / Convert.ToDouble(t.X));
                if (t.X < 0) alph += Math.PI;

            }
            return alph;
        }

        // через векторное произведение определяет поворот
        //(если величина отрицательная - поворот против часовой стрелки, и наоборот)
        double angle(Point t0, Point t1, Point t2)
        {
            return (t1.X - t0.X) * (t2.Y - t0.Y) - (t2.X - t0.X) * (t1.Y - t0.Y);
        }

        public Point[] convex_build() //построение саммой оболочки(удаление) "лишних" вершин
        {
            //p0 - точка с минимальной координатой у или самая левая из таких точек при наличии совпадений

            p0 = Q[0];
            int ind = 0;
            for (int i = 1; i < size; i++)
                if (Q[i].Y > p0.Y) { p0 = Q[i]; ind = i; }
                else
                    if (Q[i].Y == p0.Y && Q[i].X < p0.X) { p0 = Q[i]; ind = i; }

            //P остальные точки (все Q кроме р0) 
            sizeP = size - 1;
            Point[] P = new Point[sizeP];
            int j = 0;
            for (int i = 0; i < size; i++)
                if (i != ind)
                { P[j] = Q[i]; j++; }

            P = sort(P);  //сортируем Р в порядке возрастания полярного угла,измеряемого 
            //против часовой стрелки относительно р0

            Point[] S = new Point[size]; //массив,который будет содержать вершины оболочки против часовой стрелки 
            S[0] = p0; S[1] = P[0]; S[2] = P[1];
            int last = 2;
            for (int i = 2; i < sizeP; i++)
            {
                while (last > 0 && angle(S[last - 1], S[last], P[i]) >= 0) last--;
                last++;
                S[last] = P[i];
            }
            sizeP = last + 1;
            return S;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество точек");
            int n = int.Parse(Console.ReadLine());
            Point[] mas = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите точку {0}: x y", i + 1);
                mas[i] = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            }

                    //по Джарвису-------------------------------------------------------------------------
                    Console.WriteLine("По алгоритму Джарвиса");
                    int h = 0;
                    Point[] Jarvis = new Point[n];

                    for (int i = 0; i < n; i++)
                        Jarvis[i] = mas[i];

                    Point[] Newmas2 = Convex.Solve(Jarvis, ref h);
                    Point[] Helps = new Point[h];
                    for (int j = 0; j < h; j++)
                        Helps[j] = Newmas2[j];
                    Polygon Pol2 = new Polygon(Helps);

                    if (Pol2.IsPoligonConvex())
                        Console.WriteLine("Выпуклый");
                    else
                        Console.WriteLine("Невыпуклый");


                    for (int j = 0; j < Helps.Length; j++) { Console.Write("({0};{1}) ", Helps[j].x, Helps[j].y); }
                    int d = 0;
                    while ((d < n) && (Pol2.pointInPolygon(Jarvis[d]) != Polygon.PointInPolygon.OUTSIDE)) d++;
                    if (d == n)
                        Console.WriteLine("Все точки принадлежат");
                    else
                        Console.WriteLine("Не все точки принадлежат");

                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("По Алгоритму Грэхема");
                    Convex Graham = new Convex(mas);
                    Point[] Gr = Graham.convex_build();
                    for (int j = 0; j < Graham.sizeP; j++) { Console.Write("({0};{1}) ", Gr[j].x, Gr[j].y); }
                    Console.ReadLine();

                    Console.ReadLine();
        }
    }
}