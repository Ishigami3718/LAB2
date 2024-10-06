using LAB2Kurs2;
using System;
using System.Numerics;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix("1 2 n 3 4");
            MyMatrix matrix1 = new MyMatrix("5 6 n 7 8");
            Console.WriteLine(matrix*matrix1);
            // MyMatrix matrix = new MyMatrix(new double[3,3]{ { 1, 7, 8 },{ 9, 8, 4 },{ 1, 2, 3 } });
            /* Console.WriteLine(matrix);
             Console.WriteLine(matrix[0,0]);
             matrix[0, 0] = -9;
             Console.WriteLine(matrix[0,0]);
             Console.WriteLine(matrix);*/
        }
    }
}