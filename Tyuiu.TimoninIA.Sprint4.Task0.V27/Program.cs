using Tyuiu.TimoninIA.Sprint4.Task0.V27.Lib;

class Program
{
    static void Main()
    {
        int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
        int result = ArrayOperations.ProductOfOddElements(array);

        if (result != 0)
        {
            Console.WriteLine("Произведение нечетных элементов: " + result);
        }
        else
        {
            Console.WriteLine("Нет нечетных элементов в массиве.");
        }
    }
}
