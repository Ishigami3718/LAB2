using LAB2Kurs2;
using System;
using System.Numerics;
using System.Text;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* MyMatrix matrix = new MyMatrix("1 2 n 3 4 n 5 6");
              MyMatrix matrix1 = new MyMatrix("5 6 n 7 8");
              MyMatrix tm = matrix.GetTransponedCopy(matrix);
              Console.WriteLine(tm);
              // MyMatrix matrix = new MyMatrix(new double[3,3]{ { 1, 7, 8 },{ 9, 8, 4 },{ 1, 2, 3 } });
              /* Console.WriteLine(matrix);
               Console.WriteLine(matrix[0,0]);
               matrix[0, 0] = -9;
               Console.WriteLine(matrix[0,0]);
               Console.WriteLine(matrix);*/
            /*MyMatrix matrix = new MyMatrix(new double[3, 3] { { 1, 7, 8 }, { 9, 8, 4 }, { 1, 2, 3 } });
            Console.OutputEncoding = Encoding.UTF8;
            MyMatrix copy = new MyMatrix(matrix);
            copy[0, 0] = 7;
            Console.WriteLine(copy);
            Console.WriteLine(matrix);
            string matrixStr = $"{matrix}";
            Console.WriteLine(new MyMatrix(matrixStr));
            MyMatrix newm = new MyMatrix(new string[2] {"1 7 8","2 3 5"});
            Console.WriteLine(newm);
            matrix[0, 0] = Math.Sqrt(-5);
            Console.WriteLine(matrix);*/
            MyMatrix myMatrix = new MyMatrix();
            Console.WriteLine(myMatrix);

        }
    }
}