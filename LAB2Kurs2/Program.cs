using LAB2Kurs2;
using System;
namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix("3 5 7 8 n 3 4 6 8 n 1 2 3 4 n 9 0 -6 5");
            // MyMatrix matrix = new MyMatrix(new double[3,3]{ { 1, 7, 8 },{ 9, 8, 4 },{ 1, 2, 3 } });
            Console.WriteLine(matrix);
            Console.WriteLine(matrix[0,0]);
            matrix[0, 0] = -9;
            Console.WriteLine(matrix[0,0]);
            Console.WriteLine(matrix);
        }
    }
}