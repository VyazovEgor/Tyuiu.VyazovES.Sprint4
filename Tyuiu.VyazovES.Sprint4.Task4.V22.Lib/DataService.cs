using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VyazovES.Sprint4.Task4.V22.Lib
{
    public class DataService : ISprint4Task4V22
    {
        public int[,] Calculate(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 != 0) // проверка на нечетность
                    {
                        array[i, j] = 0;
                    }
                }
            }
            return array;
        }
    }
}

