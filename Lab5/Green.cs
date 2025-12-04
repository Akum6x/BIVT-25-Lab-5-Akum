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
                int minval = matrix[i, 0];

                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < minval)
                    {
                        minval = matrix[i, j];
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

                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > maxval)
                    {
                        maxval = matrix[i, j];
                        maxiex = j;
                    }
                }
                for (int j = 0; j < maxiex; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = (int)Math.Floor((double)matrix[i, j] / maxval);
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
                if (matrix[i, i] > maxDval)
                {
                    maxDval = matrix[i, i];
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
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows <= 0 || cols <= 0 || rows != cols) return;

            int maxIndex = 0;
            for (int i = 1; i < rows; i++)
                if (matrix[i, i] > matrix[maxIndex, maxIndex])
                    maxIndex = i;

            for (int i = 0; i < rows; i++)
            {
                if (i != maxIndex && i < cols && maxIndex < cols)
                {
                    int temp = matrix[maxIndex, i];
                    matrix[maxIndex, i] = matrix[i, maxIndex];
                    matrix[i, maxIndex] = temp;
                }
            }
            // end

        }
        public int[,] Task5(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows <= 1)
            {
                answer = new int[0, cols];
                return answer;
            }

            int maxSum = -1;
            int rowToDelete = 0;

            for (int i = 0; i < rows; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        currentSum += matrix[i, j];
                    }
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    rowToDelete = i;
                }
            }

            answer = new int[rows - 1, cols];
            int newRow = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i != rowToDelete)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        answer[newRow, j] = matrix[i, j];
                    }
                    newRow++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows < 2) return;

            int[] negativeCounts = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
                negativeCounts[i] = count;
            }

            int minCount = negativeCounts[0];
            int maxCount = negativeCounts[0];
            int minRowIndex = 0;
            int maxRowIndex = 0;

            for (int i = 1; i < rows; i++)
            {
                if (negativeCounts[i] < minCount)
                {
                    minCount = negativeCounts[i];
                    minRowIndex = i;
                }

                if (negativeCounts[i] > maxCount)
                {
                    maxCount = negativeCounts[i];
                    maxRowIndex = i;
                }
            }

            if (minCount == maxCount) return;

            for (int j = 0; j < cols; j++)
            {
                int temp = matrix[minRowIndex, j];
                matrix[minRowIndex, j] = matrix[maxRowIndex, j];
                matrix[maxRowIndex, j] = temp;
            }
            // end

        }
        public int[,] Task7(int[,] matrix, int[] array)
        {
            int[,] answer = null;

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (array.Length != rows)
            {
                return matrix;
            }

            int minValue = matrix[0, 0];
            int minCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                        minCol = j;
                    }
                }
            }

            answer = new int[rows, cols + 1];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= minCol; j++)
                {
                    answer[i, j] = matrix[i, j];
                }

                answer[i, minCol + 1] = array[i];

                for (int j = minCol + 1; j < cols; j++)
                {
                    answer[i, j + 1] = matrix[i, j];
                }
            }
            // end

            return answer;
        }
        public void Task8(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                int positiveCount = 0;
                int negativeCount = 0;
                int maxValue = matrix[0, j];
                int maxRowIndex = 0;

                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0) positiveCount++;
                    else if (matrix[i, j] < 0) negativeCount++;

                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxRowIndex = i;
                    }
                }

                if (positiveCount > negativeCount)
                {
                    matrix[maxRowIndex, j] = 0;
                }
                else if (negativeCount > positiveCount)
                {
                    matrix[maxRowIndex, j] = maxRowIndex;
                }
            }
            // end

        }
        public void Task9(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            // end

        }
        public (int[] A, int[] B) Task10(int[,] matrix)
        {
            int[] A = null, B = null;

            // code here
            int n = matrix.GetLength(0);
            int sizeA = n * (n + 1) / 2;
            int sizeB = n * (n - 1) / 2;

            A = new int[sizeA];
            B = new int[sizeB];

            int indexA = 0;
            int indexB = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    A[indexA] = matrix[i, j];
                    indexA++;
                }

                for (int j = 0; j < i; j++)
                {
                    B[indexB] = matrix[i, j];
                    indexB++;
                }
            }
            // end

            return (A, B);
        }
        public void Task11(int[,] matrix)
        {

            // code here
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < rows - 1; i++)
                        for (int k = i + 1; k < rows; k++)
                            if (matrix[i, j] < matrix[k, j])
                            {
                                int temp = matrix[i, j];
                                matrix[i, j] = matrix[k, j];
                                matrix[k, j] = temp;
                            }
                }
                else
                {
                    for (int i = 0; i < rows - 1; i++)
                        for (int k = i + 1; k < rows; k++)
                            if (matrix[i, j] > matrix[k, j])
                            {
                                int temp = matrix[i, j];
                                matrix[i, j] = matrix[k, j];
                                matrix[k, j] = temp;
                            }
                }
            }
            // end

        }
        public void Task12(int[][] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    bool shouldSwap = false;

                    if (array[j].Length > array[i].Length)
                    {
                        shouldSwap = true;
                    }
                    else if (array[j].Length == array[i].Length)
                    {
                        int sumI = array[i].Sum();
                        int sumJ = array[j].Sum();

                        if (sumJ > sumI)
                        {
                            shouldSwap = true;
                        }
                    }

                    if (shouldSwap)
                    {
                        int[] temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            // end

        }
    }
}
