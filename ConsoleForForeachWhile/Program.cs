using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForForeachWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };// сортировка
            
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];   //алгоритм
                        nums[i] = nums[j];//смены 
                        nums[j] = temp;   //места в массиве
                    }
                }
            }
            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }


            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 }; // переворот массива в обратном порядке
            //int n = numbers.Length; // длина массива
            //int k = n / 2;          // середина массива
            //int temp;               // вспомогательный элемент для обмена значениями
            //for (int i = 0; i < k; i++)
            //{
            //    temp = numbers[i];              //алгоритм
            //    numbers[i] = numbers[n - i - 1];//смены
            //    numbers[n - i - 1] = temp;      //места в массиве с противоположным знаком
            //}
            //foreach (int i in numbers)
            //{
            //    Console.Write($"{i} \t");
            //}

            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };// количество положительных чисел в массиве
            //int result = 0;
            //foreach (int number in numbers)
            //{
            //    if (number > 0)
            //    {
            //        result++;
            //    }
            //}
            //Console.WriteLine($"Число элементов больше нуля: {result}");

            //int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};// ручное заполнение
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //List<int> num = new List<int>(5);// Заполнение и вывод автоматом
            //for (int i = 0; i < 5; i++)
            //{
            //    num.Add(i);
            //    Console.WriteLine(num[i]);
            //}

            //List<string> num = new List<string>();// Заполнение с клавиатуры и вывод
            //while (num.Count < 5)
            //{
            //    num.Add(Console.ReadLine());
            //}
            //Console.WriteLine("---------------");
            //var i = 0;
            //while (i < num.Count)
            //{
            //    Console.WriteLine(num[i]);
            //    i++;
            //}
            //Console.ReadKey();

            //List<string> list = new List<string>();// вывод листа с помощью foreach
            //var rnd = new Random();
            //for (var i = 0; i < 10; i++)
            //{
            ////continue;// пропускает текущую итерацию
            //list.Add(rnd.Next(0, 101).ToString());
            ////break;// завершает цыкл после первого круга
            //}
            //foreach (var item in list)
            //{
            //Console.WriteLine(item);
            //}

            //for (int i = 1; i < 10; i++) // вложеные цыклы
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] numbers = { { 1, 2, 3 }, { 0, 0, 0 } };// дву разрядный массив
            //int rows = numbers.GetUpperBound(0) + 1;    // количество строк
            //int columns = numbers.Length / rows;        // количество столбцов
            // // или так
            // // int columns = numbers.GetUpperBound(1) + 1;                                           
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{numbers[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] numbers = new int[3][];// зубчатый массив(массив Массивов)
            //numbers[0] = new int[] { 1, 2 };
            //numbers[1] = new int[] { 1, 2, 3 };
            //numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine("----------\nперебор с помощью цикла foreach ");
            //foreach (int[] row in numbers)
            //{
            //    foreach (int number in row)
            //    {
            //        Console.Write($"{number} \t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------\nперебор с помощью цикла for ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write($"{numbers[i][j]} \t");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
