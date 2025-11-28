using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Green
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            answer = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int mdex = 0;
                int minval = matrix[i,0];

                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i,j] < minval)
                    {
                        minval = matrix[i,j];
                        mdex = j;
                    }
                }
                answer[i] = mdex;
            }
            
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int maxiex = 0;
                int maxval = matrix[i, 0];

                for (int j = 0; j < cols;j++)
                {
                    if (matrix[i,j] > maxval)
                    {
                        maxval = matrix[i,j];
                        maxiex = j;
                    }
                }
                for (int j = 0; j < maxiex; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        matrix[i,j] = (int)Math.Floor((double)matrix[i,j] / maxval);
                    }
                }
            }
            // end

        }
        public void Task3(int[,] matrix, int k)
        {

            // code here
            if (matrix == null)
            {
                return;
            }

            int size = matrix.GetLength(0);

            if (size != matrix.GetLength(1) || k < 0 || k >= size)
            {
                return;
            }

            int maxDcol = 0;
            int maxDval = matrix[0, 0];
            
            for (int i = 1; i < size; i++)
            {
                if (matrix[i,i] >  maxDval)
                {
                    maxDval = matrix[i,i];
                    maxDcol = i;
                }
            }
            if (maxDcol == k)
            {
                return;
            }    
            for (int i = 0; i < size; i++)
            {
                int temp = matrix[i, k];
                matrix[i, k] = matrix[i, maxDcol];
                matrix[i, maxDcol] = temp;
            }
            // end

        }
        public void Task4(int[,] matrix)
        {

            // code here

            // end

        }
        public int[,] Task5(int[,] matrix)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task6(int[,] matrix)
        {

            // code here

            // end

        }
        public int[,] Task7(int[,] matrix, int[] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task8(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here

            // end

        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            // code here

            // end

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task12(int[][] array)
        {

            // code here

            // end

        }
    }
}
