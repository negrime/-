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
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                //Console.WriteLine($"Input numbers {i + 1} raw");
                for (int j = 0; j < size; j++)
                {
                    //m[i, j] = rnd.Next(-9, 10);
                    Console.Write(m[i, j] + "\t");
                   // Console.WriteLine($"Input MATRIX {i + 1}, {j + 1}");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static bool Check(int m, ref int[] res, int resSize)
        {
            bool result = true;
            for (int i = 0; i < resSize; i++)
            {
                if (m == res[i])
                {
                    result = false;
                }
            }
            return result;

        }

        public static int[] Task(int i, ref int[,] m, out int resSize, int size, ref bool  repeat)
        {
            int[] res = new int[size];
            resSize = 0;
            
            
            for (int j = 0; j < size; j++)
            {
               if (m[j, i] > 0)
                {
                    resSize++;
                    if (j == 0)
                    {
                        res[0] = m[j, i];
                    }
                    else
                    {
                        if (Check(m[j, i], ref res, resSize))
                        {
                            //resSize++;
                            // Array.Resize(ref res, res.Length + 1);
                            // resSize++;
                            res[resSize] = m[j, i];

                        }
                        else
                            repeat = true;
                    }
                }
            }
            return res;
                     
        }
      

        public static void Main(string[] args)
        {
          
            Console.WriteLine("Input matrix size");
            int size = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] m = new int[size, size];
            int resultSize;
            int[] result;
            
         
            InputMatrix(ref m, size);
            for (int i = 0; i < size; i++)
            {
                bool repeat = false;
                result = Task(i, ref m,out resultSize, size, ref repeat);
                Console.WriteLine($"[{i + 1}] Столбец");
                for (int j = 0; j < result.Length; j++)
                {
                    if(result[j] > 0 && !repeat)
                    Console.WriteLine(result[j]);                    
                }
                Console.WriteLine();
            }
           // Task(m, size, out result);
            Console.ReadLine();
        }
           
    }
}
