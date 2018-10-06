using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class MainClass
    {
        // В данной матрице для каждого столбца найти все положительные, которые не повторяются

        public static void InputMatrix(ref int[,] m, int size)
        {

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Input numbers {i + 1} raw");
                for (int j = 0; j < size; j++)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        //public static OutPut() 

        public static int[] Task(int[,] m, int size, out int[] res)
        {
            res = new int[size * size];
            bool ok = false;
            int r = 0;
    
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (m[j, i] > 0)
                        {
                            ok = true;
                            if (j == 0 || (m[j - 1, i] != m[j, i]))
                            {
                                Console.WriteLine($"{m[j, i]} Column {i + 1} ");
                                res[r] = m[j, i];
                                r++;

                            }                          
                        }
                    }
                }
            
            if (!ok)
            {
                Console.WriteLine("Matrix hasnt positive numbers");
                return null;
            }
            else
            {
                return res;
            }
            
            

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Input matrix size");
            int size = int.Parse(Console.ReadLine());
            int[,] m = new int[size, size];
            int[] result;
            //int[] res;
            InputMatrix(ref m, size);
            Task(m, size, out result);
            Console.ReadLine();
        }
           
    }
}
