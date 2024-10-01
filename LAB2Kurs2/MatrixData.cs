using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Kurs2
{
    partial class MyMatrix
    {
        private double[,] matrix;

        public MyMatrix() { }

        public MyMatrix(MyMatrix matrix)
        {
            int row = matrix.matrix.GetLength(0);
            int col = matrix.matrix.GetLength(1);
            this.matrix = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    this.matrix[i,j] = matrix.matrix[i, j];
                }
            }
        }

        public MyMatrix(double[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            this.matrix = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.matrix[i, j] = matrix[i, j];
                }
            }
        }

        public MyMatrix(double[][] matrix)
        {
            int row = matrix.GetLength(0);
            for(int i = 0; i < row-1; i++)
            {
                if (matrix[i].Length != matrix[i + 1].Length)
                {
                    throw new Exception("not rectangular");
                }
            }
            int col = matrix[0].Length;
            this.matrix = new double[row, col];
            for(int i = 0; i < row; i++)
            {
                for( int j = 0; j < col; j++)
                {
                    this.matrix[i,j] = matrix[i][j];
                }
            }
        }

        public MyMatrix(string[] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Split().Length;
            this.matrix = new double[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.matrix[i, j] = double.Parse(matrix[i].Split()[j]);
                }
            }
        }

        public MyMatrix(string matrix)
        {
            int col = 0;
            while (matrix.Split()[col] != "n") col++;
            string[] str = matrix.Split(new char[] { ' ', '\t', 'n' },
                StringSplitOptions.RemoveEmptyEntries);
            int row = str.Length / col;
            this.matrix = new double[row, col];
            /*for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    this.matrix[i, j]= double.Parse(str[i+j+2*i]);
                }
            }*/
            int j = 0;
            for (int i = 0; i < row; i++)
            {
                do
                {
                    this.matrix[i,j%col] = double.Parse(str[j]);
                    j++;
                }
                while (j < col*(i+1));

            }
        }

        public override string ToString()
        {
            string result = "";
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result += $"{matrix[i, j]}"+"\t";
                }
                result += "\n";       
            }
            return result;
        }
    }
}
