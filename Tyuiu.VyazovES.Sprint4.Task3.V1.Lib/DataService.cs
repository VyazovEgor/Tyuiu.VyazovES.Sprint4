using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VyazovES.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;

            int lastColumn = array.GetLength(1) - 1; // Индекс последнего столбца

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, lastColumn];
            }

            return sum;
        }
    }
}

