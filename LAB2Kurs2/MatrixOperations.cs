using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Kurs2
{
    partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix m1,MyMatrix m2)
        {
            if (m1.Heigth == m2.Heigth && m1.Weidth == m2.Weidth)
            {
                MyMatrix mres = new MyMatrix();
                mres.matrix = new double[m1.Heigth, m1.Weidth];
                for (int i = 0; i < m1.Heigth; i++)
                {
                    for (int j = 0; j < m1.Weidth; j++)
                    {
                        mres[i, j] = m1[i, j] + m2[i, j];
                    }
                }
                return mres;
            }
            else throw new Exception("Different sizes");
        }

        public static MyMatrix operator *(MyMatrix m1, MyMatrix m2)
        {
            if (m1.Weidth == m2.Heigth)
            {
                MyMatrix mres = new MyMatrix();
                mres.matrix = new double[m1.Heigth, m2.Weidth];
                for (int i = 0; i < m1.Heigth; i++)
                {
                    for (int j = 0; j < m2.Weidth; j++)
                    {
                        double sum = 0;
                        for (int k = 0; k < m1.Weidth;k++)
                        {
                            sum += m1[i, k] * m2[k, j];
                        }
                        mres[i, j] = sum;
                    }
                }
                return mres;
            }
            else throw new Exception("Different cols and rows sizes");
        }

        private double[,] GetTransponedArray(MyMatrix m)
        {
            double[,] tmatrix = new double[m.Weidth, m.Heigth];
            double[] temp = new double[m.Weidth];
            for(int i = 0; i < m.Weidth; i++)
            {
                for (int k = 0; k < temp.Length; k++)
                {
                    temp[k] = matrix[i, k];
                }

                for (int j = 0; j < m.Heigth; j++)
                {
                    tmatrix[i, j] = m[j,i];
                }
                  
                for(int p = 0; p < m.Weidth; p++)
                {
                    tmatrix[p, i] = temp[p];
                }
                temp = null;
            }
            return tmatrix;
        }

        public MyMatrix GetTransponedCopy(MyMatrix m)
        {
            MyMatrix tm = new MyMatrix();
            tm.matrix = GetTransponedArray(m);
            return tm;
        }

        public void TransponeMe()
        {
            this.matrix = GetTransponedArray(this);
        }
    }
}
