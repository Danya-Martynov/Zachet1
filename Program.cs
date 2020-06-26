using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] matr = new byte[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i + j == 3)
                    {
                        matr[i, j] = 1;
                    }
                    else
                    {
                        matr[i, j] = 0;
                    }

                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matr[i, j].ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
