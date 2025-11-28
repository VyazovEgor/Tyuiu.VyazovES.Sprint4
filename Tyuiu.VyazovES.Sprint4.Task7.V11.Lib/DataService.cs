using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VyazovES.Sprint4.Task7.V11.Lib
{
    public class DataService : ISprint4Task7V11
    {
        public int Calculate(int rows, int cols, string str)
        {
            int Count = 0;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(str[i * cols + j].ToString());
                    if (matrix[i, j] % 2 != 0)
                        Count++;
                }
            }
            return Count;
        }
    }
}

