using Tyuiu.TimoninIA.Sprint4.Task5.V5.Lib;
namespace Tyuiu.TimoninIA.Sprint4.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] ar = new int[5, 5];
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.WriteLine("Введите" + i + " " + j + " элемент массива");
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Title = "Спринт #4 | Выполнил: Тимонин И.А. | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                         *");
            Console.WriteLine("* Вариант #5                                                            *");
            Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                    Console.Write(ar[i, j] + " ");
                Console.WriteLine("");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(ar));
        }
    }
}