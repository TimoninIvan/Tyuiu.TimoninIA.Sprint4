using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TimoninIA.Sprint4.Task0.V27.Lib;

public static class ArrayOperations
{
    public static int ProductOfOddElements(int[] array)
    {
        int product = 1;
        bool hasOddElements = false;

        foreach (int number in array)
        {
            if (number % 2 != 0) // проверка на нечетность
            {
                product *= number; // умножение
                hasOddElements = true; // установка флага, что есть нечетные элементы
            }
        }

        if (!hasOddElements)
            return 0; // если нет нечетных элементов, возвращаем 0 или можете использовать другое значение
        return product; // возвращаем произведение нечетных элементов
    }
}
