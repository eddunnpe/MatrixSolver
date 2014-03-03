using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix
    {
        private float[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            matrix = new float[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        public void mulRow(float mulFactor, int row)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = matrix[row, col] * mulFactor;
            }
        }

        public void mulRowAdd(float mulfactor, int fRow, int sRow)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[sRow, col] = matrix[fRow, col] * mulfactor;
            }
        }

        public void swapRow(int fRow, int sRow)
        {
            float[] fRowBuffer = new float[cols];
            float[] sRowBuffer = new float[cols];

            for (int col = 0; col < cols; col++)
            {
                fRowBuffer[col] = matrix[fRow, col];
                sRowBuffer[col] = matrix[sRow, col];
            }

            for (int col = 0; col < cols; col++)
            {
                matrix[sRow, col] = fRowBuffer[col];
                matrix[fRow, col] = sRowBuffer[col];
            }
        }
    }
}
