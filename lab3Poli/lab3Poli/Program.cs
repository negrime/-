using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab3Poli
{
    class Program
    {
        abstract class Pair
        {
            protected long roubles;
            protected byte kopeiky;
            public long Roubles
            {
                get { return roubles; }
                set { roubles = value; }
            }
            public byte Kopeyks
            {
                get { return kopeiky; }
                set { kopeiky = value; }
            }

            public abstract Money Add(Money additMoney);
            public abstract Money Substract(Money subMoney);
            public abstract Money Divide(Money divMoney);
            public abstract Money DivideBySum(string divisor);
            public abstract Money Multiply(string multiplier);
            public abstract int CompareTo(Money compMoney);
            public virtual void Read(ref Money current) { }
            public virtual void Display(Money current) { }
            public abstract string toString(Money current);
        }
        class Money : Pair
        {
        
            public override Money Add(Money additMoney)
            {
                if (additMoney.Kopeyks + this.Kopeyks > 100)
                {
                    byte additKops = (byte)(additMoney.Kopeyks + this.Kopeyks - 100);
                    long additRoubles = additMoney.Roubles + this.Roubles + 1;
                    return new Money { Roubles = additRoubles, Kopeyks = additKops };
                }
                else
                {
                    byte additKops = (byte)(additMoney.Kopeyks + this.Kopeyks);
                    long additRoubles = additMoney.Roubles + this.Roubles;
                    return new Money { Roubles = additRoubles, Kopeyks = additKops };
                }
            }

            public override Money Substract(Money subMoney)
            {
                if (this.Kopeyks - subMoney.Kopeyks < 0)
                {
                    if (this.Roubles - subMoney.Roubles < 0)
                    {
                        byte subKops = (byte)(subMoney.Kopeyks - this.Kopeyks);
                        long subRoubles = this.Roubles - subMoney.Roubles;
                        return new Money { Roubles = subRoubles, Kopeyks = subKops };
                    }
                    else
                    {
                        byte subKops = (byte)(100 + this.Kopeyks - subMoney.Kopeyks);
                        long subRoubles = this.Roubles - subMoney.Roubles - 1;
                        return new Money { Roubles = subRoubles, Kopeyks = subKops };
                    }
                }
                else
                {
                    if (this.Roubles - subMoney.Roubles < 0)
                    {
                        byte subKops = (byte)(100 - (this.Kopeyks - subMoney.Kopeyks));
                        long subRoubles = this.Roubles - subMoney.Roubles + 1;
                        return new Money { Roubles = subRoubles, Kopeyks = subKops };
                    }
                    else
                    {
                        byte subKops = (byte)(this.Kopeyks - subMoney.Kopeyks);
                        long subRoubles = this.Roubles - subMoney.Roubles;
                        return new Money { Roubles = subRoubles, Kopeyks = subKops };
                    }
                }
            }

            public override Money Divide(Money divMoney)
            {
                double divSum = (this.Roubles + this.Kopeyks * 0.01) / (divMoney.Roubles + divMoney.Kopeyks * 0.01);
                return new Money { Roubles = (Int64)Math.Truncate(divSum), Kopeyks = (byte)Math.Truncate(divSum * 100 % 100) };
            }

            public override Money DivideBySum(string divisor)
            {
                double divSum = (this.Roubles + this.Kopeyks * 0.01) / Double.Parse(divisor);
                return new Money { Roubles = (Int64)Math.Truncate(divSum), Kopeyks = (byte)Math.Truncate(divSum * 100 % 100) };
            }

            public override Money Multiply(string multiplier)
            {
                double mulSum = (this.Roubles + this.Kopeyks * 0.01) * Double.Parse(multiplier);
                return new Money { Roubles = (Int64)Math.Truncate(mulSum), Kopeyks = (byte)Math.Truncate(mulSum * 100 % 100) };
            }

            public override int CompareTo(Money compMoney)
            {
                if (this.Roubles > compMoney.Roubles)
                    return 1;
                else if (this.Roubles < compMoney.Roubles)
                    return 2;
                else if (this.Kopeyks > compMoney.Kopeyks)
                    return 3;
                else if (this.Kopeyks < compMoney.Kopeyks)
                    return 4;
                else
                    return 5;
            }
            public static void Init(ref Money current, long initialRoubles, byte initialKopeyks)
            {
                current = new Money { Roubles = initialRoubles + initialKopeyks / 100, Kopeyks = (byte)(initialKopeyks % 100) };
            }
            public override void Read(ref Money current)
            {
                string input = Console.ReadLine();
                string[] substrs = Regex.Split(input, @"[.,]");
                int integerKopeyks = Int32.Parse(substrs[1]);
                Init(ref current, Int64.Parse(substrs[0]) + integerKopeyks / 100, (byte)(integerKopeyks % 100));
            }
            public override void Display(Money current)
            {
                Console.Write(toString(current));
            }
            public override string toString(Money current)
            {
                if (current.Kopeyks < 10)
                    return current.Roubles.ToString() + ",0" + current.Kopeyks.ToString();
                else
                    return current.Roubles.ToString() + "," + current.Kopeyks.ToString();
            }
        }

        static void Main(string[] args)
        {
            Pair p = new Money();
            Money m1 = new Money();
            Money m2 = new Money();

            Console.Write("Hello, enter your 2 sums: ");
            m1.Read(ref m1);
            m2.Read(ref m2);
            p.Read(ref m1);

            Console.Write("Enter a fractional number you want to multiply and to divide: ");
            string fracNumber = Console.ReadLine();

            Console.Write("Sum: ");
            m1.Display(m1.Add(m2));

            Console.WriteLine();
            Console.Write("Sub: ");
            m1.Display(m1.Substract(m2));

            Console.WriteLine();
            Console.Write("Div: ");
            m1.Display(m1.Divide(m2));

            Console.WriteLine();
            Console.WriteLine("Div by your number: ");
            m1.Display(m1.DivideBySum(fracNumber));
            Console.WriteLine();
            m2.Display(m2.DivideBySum(fracNumber));

            Console.WriteLine();
            Console.WriteLine("Multiplication by your number: ");
            m1.Display(m1.Multiply(fracNumber));
            Console.WriteLine();
            m2.Display(m2.Multiply(fracNumber));

            Console.WriteLine();
            Console.Write("Comparison: ");
            int compare = m1.CompareTo(m2);
            switch (compare)
            {
                case 1:
                case 3:
                    {
                        m1.Display(m1);
                        Console.Write(" > ");
                        m2.Display(m2);
                        break;
                    }
                case 2:
                case 4:
                    {
                        m1.Display(m1);
                        Console.Write(" < ");
                        m2.Display(m2);
                        break;
                    }
                case 5:
                    {
                        m1.Display(m1);
                        Console.Write(" = ");
                        m2.Display(m2);
                        break;
                    }
                default: break;
            }


            Console.ReadKey();
        }
    }
}

