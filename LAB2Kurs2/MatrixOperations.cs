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
    }
}
