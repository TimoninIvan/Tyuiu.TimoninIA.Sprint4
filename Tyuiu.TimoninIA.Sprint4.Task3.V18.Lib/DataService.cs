using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TimoninIA.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int result = int.MinValue;
            int lastRowIndex = array.GetLength(0) - 1;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[lastRowIndex, j] > result)
                {
                    result = array[lastRowIndex, j];
                }
            }
            return result;
        }
    }
}